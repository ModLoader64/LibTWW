//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class kankyo_method_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public leafdraw_method_class _base {get => this.__base(); set => this.__base(value);}//;
        
        public kankyo_method_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
/*        
        private leafdraw_method_class __base() {
            return new leafdraw_method_class(this.pointer + 0x00);
        }
        
        private void __base(leafdraw_method_class value) {
        }*/
    }
}
