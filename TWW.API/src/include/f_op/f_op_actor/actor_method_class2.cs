//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class actor_method_class2 {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public actor_method_class _base {get => this.__base(); set => this.__base(value);}//;
        
        public u32 field_0x20 {get => this._field_0x20(); set => this._field_0x20(value);}//;
        
        public actor_method_class2(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private actor_method_class __base() {
            return new actor_method_class(this.pointer + 0x00);
        }
        
        private void __base(actor_method_class value) {
        }
        
        private u32 _field_0x20() {
            return Memory.RAM.ReadU32(this.pointer + 0x20);
        }
        
        private void _field_0x20(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x20, value);
        }
    }
}
