//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class actor_process_profile_definition2 {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public actor_process_profile_definition def {get => this._def(); set => this._def(value);}//;
        
        public u32 field_0x30 {get => this._field_0x30(); set => this._field_0x30(value);}//;
        
        public actor_process_profile_definition2(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x34;
        }
        
        private actor_process_profile_definition _def() {
            return new actor_process_profile_definition(this.pointer + 0x00);
        }
        
        private void _def(actor_process_profile_definition value) {
        }
        
        private u32 _field_0x30() {
            return Memory.RAM.ReadU32(this.pointer + 0x30);
        }
        
        private void _field_0x30(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x30, value);
        }
    }
}