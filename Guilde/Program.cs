
namespace Guilde
{
    internal static class Program
    {

        public static void Main()
        {

            Console.WriteLine("Welcome to the Raccoon Gang Guild!");

            Guild guild = new Guild("Raccoon Gang");
            GuildMember leader = new GuildMember("Patron", Enum.EnumRole.Leader);
            GuildMember member = new GuildMember("Salsalouche", Enum.EnumRole.Elder);
            GuildMember officer = new GuildMember("Raccoon", Enum.EnumRole.Officer);
            GuildMember noob = new GuildMember("Noobie", Enum.EnumRole.Recruit);
            guild.AddMembers(leader);
            guild.AddMembers(member);
            guild.AddMembers(officer);

            Console.WriteLine("Here are the members of the guild:");
            guild.ShowMembersList(guild.MembersList);

            guild.AddMembers(noob);
            
            
        }
    }
}

