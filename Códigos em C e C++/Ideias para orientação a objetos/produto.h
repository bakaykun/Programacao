class  Produto {
    private:

        char nome[19];
        int ean;
        float preco;
        int quantidade;

    public:

        Produto();
        void setProduto(char, int, float, int);
        void impremeProduto();
        ~Produto();
};