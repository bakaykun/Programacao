#ifndef DATA_H
#define DATA_H

class Data {
    private:
        int dia, mes, ano;
        mutable int contador;//para constantes mutáveis
        static int contaInstancias;
    public:
        Data(int = 1, int = 1, int = 1972);
        ~Data();
        //usa const quando o atributo do onj não muda, coisas que não sofrem alteração ficam constantes
        int get_dia() const { return dia;}
        int get_mes() const { return mes;}
        int get_ano() const {return ano;}
        int get_contador() const { return contador;}
        static int get_contaInstancias() { return contaInstancias;}
        void print() const ;

        Data& set_dia(int);
        Data& set_mes(int);
        Data& set_ano(int);
};




#endif