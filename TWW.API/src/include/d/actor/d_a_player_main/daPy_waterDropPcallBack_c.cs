//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class daPy_waterDropPcallBack_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8[] field_0x4 {get => this._field_0x4(); set => this._field_0x4(value);}//;
        
        //public dBgS_ObjGndChk field_0x8 {get => this._field_0x8(); set => this._field_0x8(value);}//;
        
        public daPy_waterDropPcallBack_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        // #ARRCOUNT 0x4
        private u8[] _field_0x4() {
            u8[] bytes = new u8[0x4]; for(u32 i = 0; i < 0x4; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x4 + (i * 1));} return bytes;
        }
        
        private void _field_0x4(u8[] value) {
            for(u32 i = 0; i < 0x4; i++){Memory.RAM.WriteU8(this.pointer + 0x4 + (i * 1), value[i]);}
        }
/*        
        private dBgS_ObjGndChk _field_0x8() {
            return new dBgS_ObjGndChk(this.pointer + 0x8);
        }
        
        private void _field_0x8(dBgS_ObjGndChk value) {
        }*/
    }
}