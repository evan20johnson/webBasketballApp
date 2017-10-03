using System;

namespace cs341.Tests.Controllers
{
    public class productManger
    {
		private String firstName;
		private String email;
		private int number;
        private String lastName;

        //TODO Once again need to write events out to database

		public productManger(String lN, String e, String fN, int num)
		{
			firstName = fN;
			lastName = lN;
			number = num;
			email = e;
		}
        public void createEvent(DateTime when){

            game newEvent = new game(when, null, null, null, null, null);
            
        }
        public void deleteEvent(){
            
        }
        public void deletevolunteer(){
            
        }


    }
}
