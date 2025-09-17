using UnityEngine;
using UnityEngine.UIElements;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private UIDocument uiDocument;

    private player_Exp txtSize;
    [SerializeField]
    public ScriptableObject stats_Menu;
    private VisualElement uiRoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        uiDocument = GetComponent<UIDocument>();
        uiRoot = uiDocument.rootVisualElement;
        txtSize = new player_Exp();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            txtSize.tamanhoTexto++;
            uiRoot.Q<Label>("Echoes").style.fontSize = txtSize.tamanhoTexto; //Serve para fazer a barrinha de xp ou qualquer barrinha aumentar sempre que aperto D, o negócio tem que tá no maior tamanho dele, no caso 100% na porcentagem
            if (txtSize.tamanhoTexto > 40)
            {
                txtSize.tamanhoTexto = 10;
            }
        }
    }
}

public class player_Exp
{
    public float exp = 0;
    public int tamanhoTexto;
}