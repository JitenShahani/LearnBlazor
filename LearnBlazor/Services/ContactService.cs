namespace LearnBlazor.Services;

public class ContactService
{
	public IEnumerable<Contact> GetContacts ()
	{
		return [
			new () { Name = "Mika Hakkinen", URL = "http://www.mikahakkinen.fi", Team = "McLaren", Country = "Finland" },
			new () { Name = "David Coulthard", URL = "http://www.davidcoulthard.uk", Team = "McLaren", Country = "United Kingdom" },

			new () { Name = "Jenson Button", URL = "http://www.jensonbutton.uk", Team = "Brawn GP", Country = "United Kingdom" },
			new () { Name = "Rubens Barrichello", URL = "http://www.rubensbarrichello.com.br", Team = "Brawn GP", Country = "Brazil" },

            new () { Name = "Kimi Raikkonen", URL = "http://www.kimiriakkonen.fi", Team = "Lotus", Country = "Finland" },
			new () { Name = "Romain Grosjean", URL = "http://www.romaingrosjean.fr", Team = "Lotus", Country = "France" },

            new () { Name = "Max Verstappen", URL = "http://www.maxverstappen.nl", Team = "Red Bull", Country = "Netherlands" },
			new () { Name = "Sergio Perez", URL = "http://www.perez.mx", Team = "Red Bull", Country = "Mexico" },

			new () { Name = "Charles Leclerc", URL = "http://www.charlesleclerc.com", Team = "Ferrari", Country = "Monaco" },
			new () { Name = "Lewis Hamilton", URL = "http://www.lewishamilton.uk", Team = "Ferrari", Country = "United Kingdom"},

			new () { Name = "Lando Norris", URL = "http://www.landonnorris.uk", Team = "McLaren", Country = "United Kingdom" },
			new () { Name = "Oscar Piastri", URL = "http://www.oscarpiastri.com", Team = "McLaren", Country = "Australia" },

			new () { Name = "George Russell", URL = "http://www.georgerussell.uk", Team = "Mercedes", Country = "United Kingdom" },
			new () { Name = "Andrea Kimi Antonelli", URL = "http://www.andreakimiantonelli.it", Team = "Mercedes", Country = "Italy" },

			new () { Name = "Fernando Alonso", URL = "http://www.fernandoalonso.es", Team = "Aston Martin", Country = "Spain" },
			new () { Name = "Lance Stroll", URL = "http://www.lancestroll.com", Team = "Aston Martin", Country = "Canada" },

			new () { Name = "Alexander Albon", URL = "http://www.alexalbon.com", Team = "Williams", Country = "Thailand" },
			new () { Name = "Carlos Sainz", URL = "http://www.carlossainz.es", Team = "Williams", Country = "Spain" }
            ];
	}
}