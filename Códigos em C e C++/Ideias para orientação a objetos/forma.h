#ifndef FORMA_H
#define FORMA_H

class Forma {
    protected:
        double x, y;
    public:
        Forma(double = 0, double = 0);
        ~Forma() { };

        //para redefinir as funções nas outras classes, usa-se a plavra virtual
        virtual void imprime_dados();
        virtual double area() { return 0;}
};


#endif