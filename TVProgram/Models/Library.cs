using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVProgram.Models
{
    public class Programa
    {
        public List<Shows> Showss { get; set; } = new List<Shows>();

        public List<Shows> Search(string id, string name, string genre, string type, string time, string author, string day, string channel, bool onlyFavorites)
        {
            int.TryParse(id, out int parsedId);

            var filteredShows = Showss.Where(show =>
                (string.IsNullOrEmpty(id) || show.Id == parsedId) &&
                (string.IsNullOrEmpty(name) || show.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(genre) || show.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(type) || show.Type.Contains(type, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(time) || show.Time.Contains(time, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(author) || show.Authors.Contains(author, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(day) || show.Day.Contains(day, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(channel) || show.Channel.Contains(channel, StringComparison.OrdinalIgnoreCase)));

            if (onlyFavorites)
            {
                filteredShows = filteredShows.Where(show => show.IsFavorite);
            }

            return filteredShows.ToList();
        }
        public Programa LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Programa>(jsonString);
        }
    }

}
