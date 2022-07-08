using System;

public class Vendeur : vendeur
{
    private static Vendeur _instance = null;

    private Vendeur()
    {
        documents = new List<Document>();
    }

    public static Vendeur Instance()
    {
        if (_instance == null)
            _instance = new Vendeur();
        return _instance;
    }

}