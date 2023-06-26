using SRP.Entities;
using System;


namespace SRP.Repository
{
    class Seed
    {

        List<Rooms> rooms = new List<Rooms>(){
                new Rooms(){Number = 123456, isDisponivel = false, Client = client1},
                new Rooms(){Number = 345534, isDisponivel = false, Client = client2},
                new Rooms(){Number = 234728, isDisponivel = true, Client = client3},
                new Rooms(){Number = 456784, isDisponivel = false, Client = client4}
     };
        Client client1 = new Client() { Name = "Lailton" };
        Client client2 = new Client() { Name = "Marcus" };
        Client client3 = new Client() { Name = "Quindere" };
        Client client4 = new Client() { Name = "Lorena" };
    }
}
