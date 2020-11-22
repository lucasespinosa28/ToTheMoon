using UnityEngine;

namespace Assets.Scripts
{
    public class Stages
    {
        private static int existentMeteor = 0;
        private static float speedUp = 1f;
        public static void Level(int level)
        {
            switch (level)
            {
                case int n when (n <= 3):
                    NewMethod(level,1);
                    break;
                case int n when (n <= 6):
                    NewMethod(level, 2);
                    break;
                case int n when (n <= 9):
                    NewMethod(level, 3);
                    break;
                case int n when (n <= 12):
                    NewMethod(level, 4);
                    break;
                case int n when (n <= 15):
                    NewMethod(level, 5);
                    //new Meteor().Add(1, new Vector3(Random.Range(-5.0f, 7.00f), Random.Range(-4.0f, 5.50f)), (level - 12) * 2f);
                    break;
                
            }
        }

        private static void NewMethod(int level, int numberMeteors)
        {
            if (numberMeteors == existentMeteor)
            {
                speedUp += 2f;
            }
            else
            {
                speedUp = 1f;
            }
            if (level == 1)
            {
                speedUp = 1f;
            }
         
            for (int i = 1; i <= numberMeteors; i++)
            {           
                new Meteor().Add(numberMeteors, new Vector3(Random.Range(-5.0f, 7.00f), Random.Range(-4.0f, 5.50f)), speedUp * 2f);                
                existentMeteor = numberMeteors;
            }
        }
    }
}
                //switch (n)
                //{
                //    case 1:
                //        new Meteor().Add(1, new Vector3(Random.Range(-5.0f, 7.00f), Random.Range(-4.0f, 5.50f)));
                //        break;
                //    case 2:
                //        new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -1.00f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(2, new Vector3(Random.Range(1.00f, 7.00f), Random.Range(-4.0f, 5.50f)));
                //        break;
                //    case 3:
                //        new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -3.0f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(2, new Vector3(Random.Range(-2.0f, 3.0f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(3, new Vector3(Random.Range(4.0f, 7.0f), Random.Range(-4.0f, 5.50f)));
                //        break;
                //    case 4:
                //        new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -4.0f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(2, new Vector3(Random.Range(-3.0f, 0.0f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(3, new Vector3(Random.Range(1.0f, 3.0f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(4, new Vector3(Random.Range(4.0f, 7.0f), Random.Range(-4.0f, 5.50f)));
                //        break;
                //    default:
                //        new Meteor().Add(1, new Vector3(Random.Range(-5.0f, -2.5f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(2, new Vector3(Random.Range(-3.0f, 0.5f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(3, new Vector3(Random.Range(1.0f, 2.5f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(4, new Vector3(Random.Range(3.0f, 5.5f), Random.Range(-4.0f, 5.50f)));
                //        new Meteor().Add(5, new Vector3(Random.Range(6.0f, 7.0f), Random.Range(-4.0f, 5.50f)));
                //        break;

                //}
