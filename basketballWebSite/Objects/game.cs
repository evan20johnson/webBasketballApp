using System;

namespace cs341.Tests.Controllers
{
    
    public class game
    {
		public DateTime dateTime;
		public voulnteer refOne;
		public voulnteer refTwo;
		public voulnteer scoreKeep;
		public voulnteer admissions;
		public voulnteer concession;

		public game(DateTime dt, voulnteer rOne, voulnteer rTwo, voulnteer sK, voulnteer a, voulnteer c) 
		{
			dateTime = dt;
			refOne = rOne;
			refTwo = rTwo;
			scoreKeep = sK;
			admissions = a;
			concession = c;  
        }

		public Boolean addRef(voulnteer vol)
		{
			if (refOne == null)
			{
				refOne = vol;
				return true;
			}
			else
			{
				refTwo = vol;
				return true;
			}
			
		}

		public Boolean addScoreKeeper(voulnteer vol)
		{
			if (scoreKeep == null)
			{
				scoreKeep = vol;
				return true;
			}
			return false;
		}

		public Boolean addAdmissions(voulnteer vol)
		{
			if (admissions == null)
			{
				admissions = vol;
				return true;
			}
			return false;
		}


		public Boolean addconcession(voulnteer vol)
		{
			if (concession == null)
			{
				concession = vol;
				return true;
			}
			return false;
		}

		//might not need this
		private void deleteEvent()
		{

		}


	}
}