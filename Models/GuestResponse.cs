namespace PartyInvites.Models
{
  public class GuestResponse
  {
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public bool? WillAttend { get; set; }
  }
  public static class Repository
  {
    private static List<GuestResponse> responses = new();

    public static IEnumerable<GuestResponse> Responses => responses;

    public static void AddResponse(GuestResponse response)
    {
      Console.WriteLine(response);
      responses.Add(response);
    }
  }
}

