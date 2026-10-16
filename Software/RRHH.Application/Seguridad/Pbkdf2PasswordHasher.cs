using System;
using System.Security.Cryptography;

namespace RRHH.Application.Seguridad;

/// <summary>Crea y verifica hashes PBKDF2-SHA256 sin almacenar la contrasena.</summary>
public static class Pbkdf2PasswordHasher
{
	public const int DefaultIterations = 210000;
	private const int SaltSize = 16;
	private const int HashSize = 32;

	public static PasswordHash Crear(string password, int iterations = DefaultIterations)
	{
		if (password == null)
		{
			throw new ArgumentNullException(nameof(password));
		}

		if (password.Length < 12)
		{
			throw new ArgumentException("La contrasena debe tener al menos 12 caracteres.", nameof(password));
		}

		if (iterations < 100000)
		{
			throw new ArgumentOutOfRangeException(nameof(iterations));
		}

		byte[] salt = new byte[SaltSize];
		using (RandomNumberGenerator random = RandomNumberGenerator.Create())
		{
			random.GetBytes(salt);
		}

		byte[] hash = Derivar(password, salt, iterations);
		return new PasswordHash(
			Convert.ToBase64String(hash),
			Convert.ToBase64String(salt),
			iterations);
	}

	public static bool Verificar(string password, string expectedHash, string salt, int iterations)
	{
		if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(expectedHash) ||
			string.IsNullOrWhiteSpace(salt) || iterations < 100000)
		{
			return false;
		}

		try
		{
			byte[] expected = Convert.FromBase64String(expectedHash);
			byte[] saltBytes = Convert.FromBase64String(salt);
			byte[] actual = Derivar(password, saltBytes, iterations);
			return FixedTimeEquals(actual, expected);
		}
		catch (FormatException)
		{
			return false;
		}
	}

	private static byte[] Derivar(string password, byte[] salt, int iterations)
	{
		using Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(
			password,
			salt,
			iterations,
			HashAlgorithmName.SHA256);
		return deriveBytes.GetBytes(HashSize);
	}

	private static bool FixedTimeEquals(byte[] left, byte[] right)
	{
		if (left == null || right == null || left.Length != right.Length)
		{
			return false;
		}

		int difference = 0;
		for (int index = 0; index < left.Length; index++)
		{
			difference |= left[index] ^ right[index];
		}

		return difference == 0;
	}
}

public sealed class PasswordHash
{
	public PasswordHash(string hash, string salt, int iterations)
	{
		Hash = hash;
		Salt = salt;
		Iterations = iterations;
	}

	public string Hash { get; }
	public string Salt { get; }
	public int Iterations { get; }
}
