using System;
namespace cs341.Tests.Controllers
{
    public class voulnteer
    {
		private String firstName;
		private String email;
		private int number;
		private String lastName;

		public voulnteer(String lN, String e, String fN, int num)
		{
			firstName = fN;
			lastName = lN;
			number = num;
			email = e;
		}
        public void signUpForEvent(String type, game g){
            if (type.Equals("admissions")){
                g.addAdmissions(this);
            } else if(type.Equals("concession")){
                g.addconcession(this);
            } else if(type.Equals("Score Keeper")){
                g.addScoreKeeper(this);
            } else if(type.Equals("Referees")){
                g.addRef(this);
            } 
        }
    }
}
