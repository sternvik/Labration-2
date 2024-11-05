using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace LogicLayer
{
    public class InMemoryDatabase
    {
        
        private static InMemoryDatabase _instance;

        
        public static InMemoryDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InMemoryDatabase();
                    _instance.Seed(); 
                }
                return _instance;
            }
        }

        private InMemoryDatabase()
        {
            
            adminlista = new List<Admin>();
            användarlista = new List<Användare>();
            personlista = new List<Person>();
            hyrninglista = new List<Hyrning>();
            fordonlista = new List<Fordon>();
            stationlista = new List<Station>();
        }

        public List<Admin> adminlista;
        public List<Användare> användarlista;
        public List<Person> personlista;
        public List<Hyrning> hyrninglista;
        public List<Fordon> fordonlista;
        public List<Station> stationlista;

        
        public void Seed()
        {
            Station station1 = new Station(1, "Mezangata");
            Station station2 = new Station(2, "Båtsman Gråsgata");
            Station station3 = new Station(3, "Båtsman Hisingsgata");
            Station station4 = new Station(4, "Kåserigatan");
            stationlista.Add(station1);
            stationlista.Add(station2);
            stationlista.Add(station3);
            stationlista.Add(station4);

            Person person1 = new Person("Anna", 1, "123", "Admin");
            Person person2 = new Person("Erik", 2, "abc", "Användare");
            personlista.Add(person1);
            personlista.Add(person2);

            Fordon fordon1 = new Fordon(1, "Elcykel", 100, "Tillgänglig", station1);
            Fordon fordon2 = new Fordon(2, "Elscooter", 80, "Tillgänglig", station1);
            Fordon fordon3 = new Fordon(3, "Elcykel", 90, "Tillgänglig", station2);
            Fordon fordon4 = new Fordon(4, "Elscooter", 70, "Tillgänglig", station3);
            Fordon fordon5 = new Fordon(5, "Elcykel", 60, "Tillgänglig", station4);
            fordonlista.Add(fordon1);
            fordonlista.Add(fordon2);
            fordonlista.Add(fordon3);
            fordonlista.Add(fordon4);
            fordonlista.Add(fordon5);
        }
    }
}

