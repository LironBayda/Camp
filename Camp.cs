using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camp
{
    internal class Camp
    {
        readonly int _id;
        public int Longitude { get; set; }
        public int Latitude { get; private set; }
        public int NumberOfPeople { get; private set; }
        public int NumberOfTents { get; private set; }
        public int NumberOfFlashLights { get; private set; }
        static int _lastCamp = 0;

        public Camp(int longitude, int latitude, int numberOfPeople, int numberOfTents, int numberOfFlashLights)
        {
            _lastCamp++;
            _id = _lastCamp;
            Longitude = longitude;
            Latitude = latitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFlashLights = numberOfFlashLights;
        }

        public override string ToString()
        {
            return base.ToString() + $"{_id} { Longitude} { Latitude } { NumberOfPeople} " +
                $"{ NumberOfTents} { NumberOfFlashLights}";
        }

        public override bool Equals(object obj)
        {
            Camp other = obj as Camp; 
            return other._id==this._id;
        }

        public override int GetHashCode()
        {
            return _id;
        }

        static public bool operator ==(Camp camp1, Camp camp2)
        {
            if (ReferenceEquals(camp1, null) && ReferenceEquals(camp2, null))
                return true;
            if (ReferenceEquals(camp1, null) || ReferenceEquals(camp1, null))
                return false;
                if (camp1._id == camp2._id)
                return true;
            return false;
        
        }

        static public bool operator !=(Camp camp1, Camp camp2)
        {

            return !(camp1 == camp2);
        }

        static public bool operator >(Camp camp1, Camp camp2)
        {
            if ( camp1.NumberOfPeople > camp2.NumberOfPeople)
                return false;
            return true;
        }

        static public bool operator <(Camp camp1, Camp camp2)
        {
            if ( camp1.NumberOfPeople < camp2.NumberOfPeople)
                return false;
            return true;
        }

        static public Camp operator +(Camp camp1, Camp camp2)
        {
            Camp camp = new Camp(camp1.Longitude+ camp2.Longitude,camp1.Latitude+ camp2.Latitude,
                camp1.NumberOfPeople+ camp2.NumberOfPeople, camp1.NumberOfTents+ camp2.NumberOfTents,
                camp2.NumberOfFlashLights+ camp1.NumberOfFlashLights);



            return camp;
        }

        
    }
}
