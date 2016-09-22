using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errors;

namespace rooms
{
    /// <summary>
    /// This class is an accessor class. It will contain all the functions that will let us use the room.
    /// </summary>
    class Room
    {

        //TODO: Basically Everyting.

        /// <summary>
        /// Accessor to the internal RoomSerializer class
        /// <para> We need this so that we can access the other class in this namespace, which we want to keep sealed. This keeps out code cleaner, and provides a single class (Room) through which we do everything</para>
        /// </summary>
        internal RoomSerializer serRm { get; set; }


        internal string description { get; set; }
        internal int[] items { get; set; }
        internal int[] happening { get; set; }

        public enum InitialEvent
        {
            description,
            happening,
            character

        }

        public Room(int roomNumber)
        {
            //Fetch room from database
        }


        public string RoomInitializer(InitialEvent iEvent)
        {
            if (iEvent == InitialEvent.character)
                return description;
            else throw new AdventureException();
        }
        

    }

    /// <summary>
    /// This class allows us to effectively store the room in such a way that it'll be quicker and take less resources to access
    /// </summary>
    internal class RoomSerializer
    {
        //TODO Create storage argument - figure out a good database. Mongo? probably non-sql.
    }
}
