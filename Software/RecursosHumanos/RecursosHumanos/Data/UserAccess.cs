namespace RecursosHumanos.Data;

internal sealed class UserAccess
{
	public int UserId { get; set; }

	public string Login { get; set; }

	public int? EmployeeId { get; set; }

	public int? OrganizationAreaId { get; set; }

	public int RoleId { get; set; }

	public string EmployeeName { get; set; }
}
