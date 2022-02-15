#include <iostream>
#include <string.h>
#include <time.h>
#include <locale.h>

class dado{
    protected:

    int faces;

    public:

    dado () { faces = 100; }
    ~dado () { }
    int random_generator (){
        int resultado;

        for (int i = 0; i < this->faces; i++ ){
        resultado = rand () % this->faces + 1;
    }

    return resultado;
    }
};

class guarda {
  int posicao;
  int bonus (int lvl){
    int bonus_guarda;
    return bonus_guarda = 3*lvl;
  }

  public:
  int bonus_guarda (int lvl) { return bonus (lvl); }
  virtual int defini_guarda () {
    std::cout << "Defina a posição da sua guarda" <<std::endl;
    std::cout << "[1] ------------------------- Alta" <<std::endl;
    std::cout << "[2] ------------------------ Baixa" <<std::endl;
    std::cout << "[3] ---------------------- Direita" <<std::endl;
    std::cout << "[4] --------------------- Esquerda" <<std::endl;
    std::cout << "[5] ------------------------ Longa" <<std::endl;
    std::cin >> this->posicao;

    if (this->posicao < 1 || this->posicao > 5){
      std::cout << "Entrada invalida" << std::endl;
      return defini_guarda();
    }

    return  this->posicao;
  }

};

class ataque: public guarda, public dado{
  int bonus (int strenght, int lvl){

    int bonus = 0;
    bonus = random_generator() + (strenght*0.6) + bonus_guarda(lvl);
        
    return bonus;
  }

  int dano_ao_oponente (int n_dados){
    int *dano;
    this->faces = 4;

    dano = new int [n_dados];

    for (int i = 0; i < n_dados; i++){
      dano [i] = this->random_generator ();
    }

    int dano_total = 0;
    for (int i = 0; i < n_dados; i++){
      dano_total = dano_total + dano[i];
    }

    std::cout << "Dano total " << dano_total <<std::endl;

    delete dano;

  return dano_total;
  }
  public:

  int defini_guarda() {
    int guarda;
    std::cout << "Escolha a posição que irá atacar" <<std::endl;
    std::cout << "[1] ------------------------- Alta" <<std::endl;
    std::cout << "[2] ------------------------ Baixa" <<std::endl;
    std::cout << "[3] ---------------------- Direita" <<std::endl;
    std::cout << "[4] --------------------- Esquerda" <<std::endl;
    std::cout << "[5] ------------------------ Longa" <<std::endl;
    std::cin >> guarda;

    if (guarda < 1 || guarda >5){
      std::cout << "Entrada invalida" << std::endl;
      return defini_guarda();
    }

    return guarda;
  }
  
  int bonus_ataque (int strenght, int lvl){ return bonus(strenght, lvl); }
  int acessa_ataque (int n_dados) { return dano_ao_oponente(n_dados); }

};

class defesa: public dado {
  int bonus_defesa () {
    int bonus = 0;

    bonus = random_generator() ;
        
    return bonus;
  }

  int bloqueio (int n_dados){
    int *defesa;
    this->faces = 4;

    defesa = new int [n_dados];

    for (int i = 0; i < n_dados; i++){
      defesa [i] = this->random_generator ();
    }

    int defesa_total = 0;
    for (int i = 0; i < n_dados; i++){
      defesa_total = defesa_total + defesa[i];
    }

    std::cout << "Voce recebe uma reducao de dano de " << defesa_total  << " hit points"<<std::endl;

    delete defesa;

    return defesa_total;
    }

  public:
    int acessa_defesa (int n_dados){ return bloqueio(n_dados); }
    int acessa_bonus () { return bonus_defesa (); }

};
class personagem: public ataque, public defesa{
  std::string nome;
  int lvl;
  
  protected:
  int strenght = 50;

  public:
  personagem () {
    std::cout << "Defina o nome de seu personagem" << std::endl;
    std::cin >> nome;
  }
  ~personagem () { }
  int hit_points = 50;

  std::string retorna_nome (personagem) { return nome; }
  int retorna_forca () { return this->strenght; }

};

class enemy: public ataque{
  int strenght = 10;

  public:
  int hit_points = 50;
};

int combate (personagem prota, enemy generico, int aux);

int main() {
  setlocale (LC_ALL, "Portuguese");
  srand (time(NULL));

  personagem prota;
  enemy generico;
  guarda pp, *pprota;
  int aux;  

  pprota = &pp;
  aux = pprota->defini_guarda();


  combate (prota, generico, aux);
} 

int combate (personagem prota, enemy generico, int aux){
  guarda *pg;
  std::string a;
  int b, bonus = 0;


    std::cout << "Deseja atacar ou defender?" <<std::endl;
    std::cout << "Atacar -------------> Aperte A" <<std::endl;
    std::cout << "Defender -----------> Aperte B" <<std::endl;
    std::cin >> a;

    if (a == "A"){

      std::cout << "Rola-se o d100 + bonus para determinar o ataque" <<std::endl;

      pg = &prota;
      b = pg->defini_guarda();


      if (b == aux){
        bonus = prota.bonus_ataque(prota.retorna_forca(), 1);
      } 
      else {
        bonus = prota.bonus_ataque(prota.retorna_forca(), 0);
      }

      std::cout << bonus <<std::endl;

      if (bonus < 40){
        std::cout << "Seu ataque e inefetivo..." <<std::endl;
      
      } else if ( bonus > 41 && bonus < 50){
        generico.hit_points = generico.hit_points - prota.acessa_ataque(1) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 51 && bonus < 60){
        generico.hit_points = generico.hit_points - prota.acessa_ataque(2) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 61 && bonus < 70){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(3) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 71 && bonus <80){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(4);

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 81 && bonus < 90){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(5) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hitpoints agora" <<std::endl;

      } else if (bonus > 91 && bonus < 100){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(6) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 101 && bonus < 110){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(7) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 111 && bonus < 120){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(8) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus > 121 && bonus < 129){

        generico.hit_points = generico.hit_points - prota.acessa_ataque(9) ;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;

      } else if (bonus == 130){

        std::cout << "Voce impunha toda sua forca em sua arma, e desfere um ataque em seu oponente"<<std::endl;

        int dano = prota.retorna_forca();

        std::cout << "Voce causa "<< dano <<" de dano em seu oponente" <<std::endl;
        generico.hit_points = generico.hit_points - dano;

        std::cout << "O oponente esta com " << generico.hit_points << " de hit points agora" <<std::endl;
      }
            
    }else if (a == "B"){

    }else std::cout << "Entrada invalida" <<std::endl;

  if (generico.hit_points <= 0){
    return 0;
  }

  if (prota.hit_points <= 0){
    return 0;
  }

  return combate(prota, generico, aux);
}