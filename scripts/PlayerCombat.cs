using TMPro;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public float cooldownTime = 2f;
    private float nextAttackTime = 0f;


    //Indicador de ataque visual
    public TextMeshPro attackIndicator;

    public enum AttackType { Pedra, Papel, Tesoura}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime){

            // Atacar Pedra
            if(Input.GetKeyDown(KeyCode.Mouse0))
                Attack(AttackType.Pedra);

            //Atacar Papel
            if(Input.GetKeyDown(KeyCode.Mouse1))
                Attack(AttackType.Papel);
            
            //Atacar Tesoura
            if(Input.GetKeyDown(KeyCode.Mouse0) && Input.GetKeyDown(KeyCode.Mouse1))
                Attack(AttackType.Tesoura);
        }
    }


    void Attack(AttackType attack){


        // Mostrar qual ataque foi indicado
        attackIndicator.text = attack.ToString();
        attackIndicator.color = GetAttackColor(attack);

        Debug.Log($"Ataque usado: {attack}");

        nextAttackTime = Time.time + cooldownTime;

        // Limpa após 1 segundo
        Invoke(nameof(ClearIndicator), 1f); 

    }


    void ClearIndicator(){
        attackIndicator.text = "";
    }



    Color GetAttackColor(AttackType attack){
        switch(attack){
            case AttackType.Pedra: return Color.red;
            case AttackType.Papel: return Color.blue;
            case AttackType.Tesoura: return Color.green;
            default: return Color.white;
        }
    }
}
