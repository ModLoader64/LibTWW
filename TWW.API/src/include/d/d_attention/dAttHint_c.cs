//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dAttHint_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u32 mHintActorID {get => this._mHintActorID(); set => this._mHintActorID(value);}//;
        
        public u32 mPriority {get => this._mPriority(); set => this._mPriority(value);}//;
        
        public u32 field_0x8 {get => this._field_0x8(); set => this._field_0x8(value);}//;
        
        public dAttHint_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private u32 _mHintActorID() {
            return Memory.RAM.ReadU32(this.pointer + 0x0);
        }
        
        private void _mHintActorID(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x0, value);
        }
        
        private u32 _mPriority() {
            return Memory.RAM.ReadU32(this.pointer + 0x4);
        }
        
        private void _mPriority(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x4, value);
        }
        
        private u32 _field_0x8() {
            return Memory.RAM.ReadU32(this.pointer + 0x8);
        }
        
        private void _field_0x8(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x8, value);
        }
    }
}
