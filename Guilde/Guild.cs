using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guilde
{
    public class Guild
    {
        public string Name { get; set; }
        public List<GuildMember> MembersList = new List<GuildMember>();

        private int _membersNumber;

        public int MembersNumber
        {
            get { return _membersNumber; }
            set
            {
                if (value >= 0 && value <= 3)
                {
                    _membersNumber = value;
                }
                else
                {
                    Console.WriteLine("The maximum number of members is 3");
                }
            }
        }
      
        public Guild(string name)
        {
            this.Name = name;
        }

        public bool IsFull(int membersNumber)
        {
            //if (membersNumber == 3)
            //{
            //    return true;
            //}
            //else return false;

            return membersNumber == 3;
        }

        public void AddMembers(GuildMember player)
        {
            
            if (IsFull(this.MembersNumber)){
                Console.WriteLine("Guild is full, you cannot add a new member");
            } else
            {
                this.MembersList.Add(player);
                MembersNumber++;
            }
        }

        public void ShowMembersList(List<GuildMember> membersList)
        {
            foreach (GuildMember member in membersList)
            {
                Console.WriteLine($"Pseudo: {member.Pseudo} \nRole: {member.Role}");
                Console.WriteLine();
            }
        }
    }
}
