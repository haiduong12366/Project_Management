using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScreenAppDemo.DTO
{
    internal class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdLeader { get; set; }
        public byte[] Avatar { get; set; }

        public Team() { }

        public Team(DataRow row)
        {
            Id = (int)row["id"];
            Name = row["name"].ToString();
            Description = row["description"].ToString();
            IdLeader = (int)row["idLeader"];
            Avatar = (byte[])row["avatar"];
        }

    }
}
