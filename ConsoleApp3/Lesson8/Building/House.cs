using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Lesson8.House
{
    class House
    {
        public string Door;
        public string FrontDoor;

        private string backDoor;
        private int numberOfRooms;
        private bool hasBathroom;

        public House(string frontDoor, string door, string backDoor)
        {
            Door = door;
            this.backDoor = backDoor;
            
            
        }

        public void OpenDoor()
        {
            
        }

        private void SetHeatingTemperature()
        {

        }

    }
}
