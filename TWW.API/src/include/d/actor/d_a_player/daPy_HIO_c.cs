//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class daPy_HIO_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8[] temp {get => this._temp(); set => this._temp(value);}//;
        
        public daPy_HIO_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x3F;
        }
        
        // #ARRCOUNT 63
        private u8[] _temp() {
            u8[] bytes = new u8[63]; for(u32 i = 0; i < 63; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x00 + (i * 1));} return bytes;
        }
        
        private void _temp(u8[] value) {
            for(u32 i = 0; i < 63; i++){Memory.RAM.WriteU8(this.pointer + 0x00 + (i * 1), value[i]);}
        }
    }
}
