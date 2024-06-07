using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Tech Street", "1011 AB", "Amsterdam", "Netherlands");
		DateTime eventDate = new DateTime(2024, 10, 15, 10, 0, 0);
        TimeSpan duration = new TimeSpan(2, 0, 0);
        LectureEvent lectureEvent = new LectureEvent(
            "AI Regulations",
            "Join us to about the evolving landscape of artificial intelligence and the regulations that govern it. This event is designed for technology professionals, policymakers, academics, and anyone interested in the impact and governance of AI technologies.",
            address,
            eventDate,
            duration,
            "Aleph Alpha",
            70
        );
        address = new Address("456 Culture Avenue", "10115", "Berlin", "Germany");
		eventDate = new DateTime(2024, 11, 20, 10, 0, 0);
        duration = new TimeSpan(2, 0, 0);
        ReceptionEvent receptionEvent = new ReceptionEvent(
            "Cultural Exchange Reception",
            "Join us for an evening reception to celebrate cultural diversity and exchange.",
            address,
            eventDate,
            duration,
            "rsvp@culturexchange.com"
        );
        address = new Address("789 Park Lane", "SW1A 1AA", "London", "United Kingdom");
		eventDate = new DateTime(2024, 8, 12, 16, 0, 0);
        duration = new TimeSpan(4, 0, 0);
        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent(
            "Community Picnic",
            "Join us for a fun-filled community picnic with games, food, and activities for all ages.",
            address,
            eventDate,
            duration,
            "Sunny with a high of 25°C"
        );
        
        Event[] events = [lectureEvent, receptionEvent, outdoorGatheringEvent];
        foreach (Event evt in events)
        {
            Console.WriteLine();
            Console.WriteLine("======= Standard Details =======");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("======= Full Details =======");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("======= Short Description =======");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("****************************************************");
        }
    }
}