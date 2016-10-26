using UnityEngine;
using System.Collections;

public class RandomNumber : MonoBehaviour {

    public static float RandomFromStandardNormalDistribution()
    {

        // This code follows the polar form of the muller transform:
        // https://en.wikipedia.org/wiki/Box%E2%80%93Muller_transform#Polar_form
        // also known as Marsaglia polar method 
        // https://en.wikipedia.org/wiki/Marsaglia_polar_method


        // calculate points on a circle
        float u, v;

        float s; // this is the hypotenuse squared.
        do
        {
            u = Random.Range(-1f, 1f);
            v = Random.Range(-1f, 1f);
            s = (u * u) + (v * v);
        } while (!(s != 0 && s < 1)); // keep going until s is nonzero and less than one

        // TODO allow a user to specify how many random numbers they want!
        // choose between u and v for seed (z0 vs z1)
        float seed;
        if (Random.Range(0, 2) == 0)
        {
            seed = u;
        }
        else
        {
            seed = v;
        }

        // create normally distributed number.
        float z = seed * Mathf.Sqrt(-2.0f * Mathf.Log(s) / s);

        return z;
    }
}
