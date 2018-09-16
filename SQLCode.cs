using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace SHSU_ELO_Project
{
    class SQLCode
    {

        // location of the database
        readonly string connectionString = "server=50.24.236.179;database=shsuelo;uid=shsucamp;pwd=camppassword;connection timeout=2";

        // Used to apply SQL commands to database
        MySqlCommand mysql_cmd;

        // Used to retrieve data from database
        MySqlDataReader mysql_datareader;

        // Actual databse connection
        MySqlConnection mysql_conn;

        public bool isServerConnected()
        {
            try
            {
                mysql_conn = new MySqlConnection(connectionString);
                mysql_conn.Open();
                mysql_conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public int checkVersion()
        {
            int version = 0;
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT version FROM versionNumber";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                version = mysql_datareader.GetInt32(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return version;
        }

        public void addUser(string name, string pass)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "INSERT INTO users (username, password) VALUES ('" + name + "', '" + pass + "')";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public string findPass(string username)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT password FROM users WHERE username = '" + username + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayer(string username)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT username FROM players WHERE username = '" + username + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found.ToLower();
        }

        public int findElo (string username)
        {
            int found = 0;
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT elo FROM players WHERE username = '" + username + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetInt32(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public int findCoachElo(string name)
        {
            int found = 0;
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT elo FROM coaches WHERE coachName = '" + name + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetInt32(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public void updateElo (string username, int elo)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "UPDATE players SET elo = '" + elo + "' WHERE username = '" + username + "'";
            mysql_conn.Open();
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public void updateCoachElo(string name, int elo)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "UPDATE coaches SET elo = '" + elo + "' WHERE coachName = '" + name + "'";
            mysql_conn.Open();
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public string findCoach5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT coachName FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findCoach3v3(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT coachName FROM teams3v3 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findTeam5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT teamName FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findTeam3v3(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT teamName FROM teams3v3 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findTeamMember5v5(string teamName, string player)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT " + player + " FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findTeamMember3v3(string teamName, string player)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT " + player + " FROM teams3v3 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerOne5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p1username FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerTwo5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p2username FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerThree5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p3username FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerFour5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p4username FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerFive5v5(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p5username FROM teams5v5 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerOne3v3(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p1username FROM teams3v3 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerTwo3v3(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p2username FROM teams3v3 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public string findPlayerThree3v3(string teamName)
        {
            string found = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT p3username FROM teams3v3 WHERE teamName = '" + teamName + "'";
            mysql_conn.Open();
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                found = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return found;
        }

        public int count(string table, string col, string where)
        {
            int count = 0;
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT COUNT(" + col + ") FROM " + table + " " + where;
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                count = mysql_datareader.GetInt16(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return count;
        }

        public void add5v5Team(int id, string teamName, string coachName, string p1, string p2, string p3, string p4, string p5)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "INSERT INTO teams5v5 (id, teamName, coachName, p1username, p2username, p3username, p4username, p5username)" +
                "VALUES ('" + id + "', '" +  teamName + "', '" + coachName + "', '" + p1 + "', '" + p2 + "', '" + p3 + "', '" + p4 + "', '" + p5 + "')";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public void delete5v5Team(string teamName)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "UPDATE teams5v5 SET isDeleted = '" + 1 + "'" + "WHERE teamName = '" + teamName + "'; UPDATE teams5v5 SET teamName = '' WHERE teamName = '" + teamName + "'";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public void add3v3Team(int id, string teamName, string coachName, string p1, string p2, string p3)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "INSERT INTO teams3v3 (id, teamName, coachName, p1username, p2username, p3username)" +
                "VALUES ('" + id + "', '" + teamName + "', '" + coachName + "', '" + p1 + "', '" + p2 + "', '" + p3 + "')";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public void delete3v3Team(string teamName)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "UPDATE teams3v3 SET isDeleted = '" + 1 + "'" + "WHERE teamName = '" + teamName + "'; UPDATE teams3v3 SET teamName = '' WHERE teamName = '" + teamName + "'";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public void addPlayer(string player, int id)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            // Default value for this is 1000. Is currently 960 due to new players missing a LAN
            mysql_cmd.CommandText = "INSERT INTO players (id, username, elo)" + "VALUES ('" + id + "', '" + player + "', '" + 960 + "')";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public void addCoach(string name, int id)
        {
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "INSERT INTO coaches (id, coachName, elo)" + "VALUES ('" + id + "', '" + name + "', '" + 1000 + "')";
            mysql_cmd.ExecuteNonQuery();
            mysql_conn.Close();
        }

        public List<string> populate5v5TeamListBox()
        {
            string name = "";
            List<string> listOfTeams = new List<string>();
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT teamName FROM teams5v5 WHERE isDeleted = '" + 0 + "'"; // WHERE id = " + id;
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                name = mysql_datareader.GetString(0);
                listOfTeams.Add(name);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return listOfTeams;
        }

        public List<string> populate3v3TeamListBox()
        {
            string name = "";
            List<string> listOfTeams = new List<string>();
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT teamName FROM teams3v3 WHERE isDeleted = '" + 0 + "'"; // WHERE id = " + id;
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                name = mysql_datareader.GetString(0);
                listOfTeams.Add(name);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return listOfTeams;
        }

        public List<string> populatePlayerBox()
        {
            string name = "";
            List<string> listOfPlayers = new List<string>();
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT username FROM players ORDER BY elo DESC, username ASC";
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                name = mysql_datareader.GetString(0);
                listOfPlayers.Add(name);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return listOfPlayers;
        }

        public string read_data(string cmd)
        {
            string name = "";
            mysql_conn = new MySqlConnection(connectionString);
            mysql_conn.Open();
            mysql_cmd = mysql_conn.CreateCommand();
            mysql_cmd.CommandText = cmd;
            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                name = mysql_datareader.GetString(0);
            }
            mysql_datareader.Close();
            mysql_conn.Close();
            return name;
        }

    }
}