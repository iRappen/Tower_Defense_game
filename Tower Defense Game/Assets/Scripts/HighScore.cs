using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HighScore
{
    public int Score { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int ID { get; set; }
    public HighScore(int id, int Score, string name, DateTime date)
    {
        this.Score = Score;
        this.Name = name;
        this.Date = date;
        this.ID = id;
    }
}