namespace RefStruct {
    public ref struct  Pessoa {
        public int idade { get; set; }
        public string Nome { get; set; }

        public Endereco EnderecoPessoa {get; set;}
    }
}