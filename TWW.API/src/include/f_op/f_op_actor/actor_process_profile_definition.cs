//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class actor_process_profile_definition {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public leaf_process_profile_definition mBase {get => this._mBase(); set => this._mBase(value);}//;
        
        public actor_method_class mSubMtd {get => this._mSubMtd(); set => this._mSubMtd(value);}//;
        
        public u32 mStatus {get => this._mStatus(); set => this._mStatus(value);}//;
        
        public u8 mGroup {get => this._mGroup(); set => this._mGroup(value);}//;
        
        public u8 mCullType {get => this._mCullType(); set => this._mCullType(value);}//;
        
        public actor_process_profile_definition(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x30;
        }
        
/*        private leaf_process_profile_definition _mBase() {
            return new leaf_process_profile_definition(this.pointer + 0x00);
        }
        
        private void _mBase(leaf_process_profile_definition value) {
        }*/
        
        private actor_method_class _mSubMtd() {
            return new actor_method_class(this.pointer + 0x24);
        }
        
        private void _mSubMtd(actor_method_class value) {
        }
        
        private u32 _mStatus() {
            return Memory.RAM.ReadU32(this.pointer + 0x28);
        }
        
        private void _mStatus(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x28, value);
        }
        
        private u8 _mGroup() {
            return Memory.RAM.ReadU8(this.pointer + 0x2C);
        }
        
        private void _mGroup(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x2C, value);
        }
        
        private u8 _mCullType() {
            return Memory.RAM.ReadU8(this.pointer + 0x2D);
        }
        
        private void _mCullType(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x2D, value);
        }
    }
}
