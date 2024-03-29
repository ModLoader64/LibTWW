//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class stage_actor_data_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public char[] mName {get => this._mName(); set => this._mName(value);}//;
        
        public u32 mParameter {get => this._mParameter(); set => this._mParameter(value);}//;
        
        public cXyz mSpawnPos {get => this._mSpawnPos(); set => this._mSpawnPos(value);}//;
        
        public csXyz mAngle {get => this._mAngle(); set => this._mAngle(value);}//;
        
        public u16 mSetId {get => this._mSetId(); set => this._mSetId(value);}//;
        
        public stage_actor_data_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x20;
        }
        
        // #ARRCOUNT 8
        private char[] _mName() {
            char[] bytes = new char[8]; for(u32 i = 0; i < 8; i++){bytes[i] = (char)Memory.RAM.ReadU8(this.pointer + 0x00 + (i * 1));} return bytes;
        }
        
        private void _mName(char[] value) {
            for(u32 i = 0; i < 8; i++){Memory.RAM.WriteU8(this.pointer + 0x00 + (i * 1), (u8)value[i]);}
        }
        
        private u32 _mParameter() {
            return Memory.RAM.ReadU32(this.pointer + 0x08);
        }
        
        private void _mParameter(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x08, value);
        }
        
        private cXyz _mSpawnPos() {
            return new cXyz(this.pointer + 0x0C);
        }
        
        private void _mSpawnPos(cXyz value) {
        }
        
        private csXyz _mAngle() {
            return new csXyz(this.pointer + 0x18);
        }
        
        private void _mAngle(csXyz value) {
        }
        
        private u16 _mSetId() {
            return Memory.RAM.ReadU16(this.pointer + 0x1E);
        }
        
        private void _mSetId(u16 value) {
            Memory.RAM.WriteU16(this.pointer + 0x1E, value);
        }
    }
}
