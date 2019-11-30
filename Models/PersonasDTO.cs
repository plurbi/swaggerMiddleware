using System;

namespace swaggerMiddleware {
    public class PersonaDTO{
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ParametrosDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Value { get; set; }     
    }
}