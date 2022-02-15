#ifndef TEMPO_H
#define TEMPO_H
//arquivo de cabeçaçalho
class Tempo {
private:
    int hora, minuto, segundo;
public:
    Tempo();
    Tempo(int, int, int);
    void setTempo(int, int, int);
    void imprime();
    void pula();
    ~Tempo() {} ;
};
#endif

