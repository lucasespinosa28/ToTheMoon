using System.Linq;
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
                case int n when (n < 3):
                    new Meteor().Add(0, new Vector3(Random.Range(-5, 7), 0), level);
                    //AddMeteor(level,1);
                    break;
                case int n when (n < 6):
                    //AddMeteor(level, 2);
                    new Meteor().Add(0, new Vector3(Random.Range(-5, -1), 0), level-6 / 10);
                    new Meteor().Add(1, new Vector3(Random.Range(1, 7), 0), level-6 / 10);
                    break;
                case int n when (n < 9):
                    //AddMeteor(level, 3);
                    new Meteor().Add(0, new Vector3(Random.Range(-5, -1), 0), level - 9 / 10);
                    new Meteor().Add(1, new Vector3(Random.Range(0, 3), 0), level - 9 / 10);
                    new Meteor().Add(2, new Vector3(Random.Range(4, 7), 0), level - 9 / 10);
                    break;
                case int n when (n < 12):
                    //AddMeteor(level, 4);
                    new Meteor().Add(0, new Vector3(Random.Range(-5, -3), 0), level - 12/10);
                    new Meteor().Add(1, new Vector3(Random.Range(-2, 1), 0), level - 12/10);
                    new Meteor().Add(2, new Vector3(Random.Range(2, 4), 0), level - 12/10);
                    new Meteor().Add(3, new Vector3(Random.Range(5, 7), 0), level - 12/10);
                    break;
                case int n when (n < 15):
                    new Meteor().Add(0, new Vector3(Random.Range(-5, -4), 0), level - 15/10);
                    new Meteor().Add(1, new Vector3(Random.Range(-3, -2), 0), level - 15/10);
                    new Meteor().Add(2, new Vector3(Random.Range(1, 2), 0), level - 15/10);
                    new Meteor().Add(3, new Vector3(Random.Range(3, 4), 0), level - 15/10);
                    new Meteor().Add(4, new Vector3(Random.Range(5, 7), 0), level - 15/10);
                    break;
                case int n when (n >= 15):
                    new Meteor().Add(0, new Vector3(Random.Range(-5.0f, -4f), 0), level);
                    new Meteor().Add(1, new Vector3(Random.Range(-3f, -2f), 0), level);
                    new Meteor().Add(2, new Vector3(Random.Range(-1f, 0f), 0), level);
                    new Meteor().Add(3, new Vector3(Random.Range(1f, 2f), 0), level);
                    new Meteor().Add(4, new Vector3(Random.Range(3, 4f), 0), level);
                    new Meteor().Add(5, new Vector3(Random.Range(5, 7f), 0), level);
                    break;

            }
        }

        private static void AddMeteor(int level, int numberMeteors)
        {
            if (numberMeteors == existentMeteor)
            {
                speedUp += 1.25f;
            }
            else
            {
                speedUp = 1f;
            }
            if (level == 1)
            {
                speedUp = 1f;
            }
            var PositionsX = new float[1000];
            for (int i = 0; i < PositionsX.Length; i++)
            {
                PositionsX[i] = Random.Range(-5, 7);
            }
            var UniquePositionsX = PositionsX.Distinct().ToArray().Take(numberMeteors);

            var meteorId = 0;
            foreach (var X in UniquePositionsX)
            {
                Debug.Log(X+2);
                new Meteor().Add(meteorId, new Vector3(X, 0), speedUp * 2f);
                meteorId++;
            }
            existentMeteor = numberMeteors;       
           
        }
    }
}