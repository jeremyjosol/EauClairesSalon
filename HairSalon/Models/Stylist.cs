using System.Collections.Generic;
using MySqlConnector;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public List<Client> Clients { get; set; }
  }
}