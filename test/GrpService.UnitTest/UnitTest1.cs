using GrpcService;

namespace GrpService.UnitTest;


public enum Status
{
	None = 0,
	PartTime = 1,
	FullTime = 2,
	Terminated = 3
}

public class User
{
	public Guid Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public DateOnly HireDate { get; set; }
	public Status Status { get; set; }
	public DateTime CreatedOn { get; set; }
	public DateTime UpdatedOn { get; set; }
}

[UsesVerify]
public class UnitTest1
{
	[Fact]
	public Task Test1()
	{
		User user = new()
		{
			Id = Guid.Parse("fdcd2958-7901-480b-ae5a-942923534fe6"),
			FirstName = "Al",
			LastName = "Zaudtke",
			HireDate = new DateOnly(2001, 10, 30),
			Status = Status.FullTime,
			CreatedOn = DateTime.Now,
			UpdatedOn = DateTime.Now.AddDays(10)
		};


		return Verify(user);
	}

	[Fact]
	public Task TestProtoMessage()
	{
		HelloReply reply = new() { Message = "A Proto Message Property!" };

		return Verify(reply);
	}
}
