namespace JogoRpg.src.Entities {
    public class Character{
        public string Name {get; set; }
        public int Level {get; set; }
        public int Life { get; set; }
        public int MagicPower { get; set; }
        public string  Category { get; set; }

        public Character(){}

        public Character( string Name, int Lavel, int Life, int MagicPower, string Category){
            this.Name = Name;
            if ( Lavel <= 43) {
                this.Level = Lavel;
            } else {
                throw new System.Exception("Lavel não disponível");
            }
            this.Life = Life;
            this.MagicPower = MagicPower;
            this.Category = Category;
        }

        public override string ToString(){
            return $@"
            Nome do Guerreiro: {this.Name}
            Nível: {this.Level}
            HP: {this.Life}
            Magia: {this.MagicPower}
            Classe: {this.Category}        
            ";
        }
    }

    
}