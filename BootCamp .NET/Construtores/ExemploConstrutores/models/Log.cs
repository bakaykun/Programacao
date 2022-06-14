namespace ExemploConstrutores.models{
    public class Log{
        //usando o padrão sigoton, para ter o mesmo objeto em vários locais do cídigo
        //usa o construtor privado quando quer evitar a instacia de uma classe 
        private static Log ?_log;
        public int MyPropertyLog { get; set; }
        private Log(){}

        public static Log GetInstance(){
            if (_log == null){
                _log = new Log();
            }

            return _log;
        }
    }
}