//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class scene_process_profile_definition {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public node_process_profile_definition mBase {get => this._mBase(); set => this._mBase(value);}//;
        
        public scene_method_class mpMtd {get => this._mpMtd(); set => this._mpMtd(value);}//;
        
        public u32 field_0x24 {get => this._field_0x24(); set => this._field_0x24(value);}//;
        
        public scene_process_profile_definition(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
/*        private node_process_profile_definition _mBase() {
            return new node_process_profile_definition(this.pointer + 0x00);
        }
        
        private void _mBase(node_process_profile_definition value) {
        }*/
        
        // Subclassmethods
        private scene_method_class _mpMtd() {
            return new scene_method_class(this.pointer + 0x20);
        }
        
        private void _mpMtd(scene_method_class value) {
        }
        
        // padding?
        private u32 _field_0x24() {
            return Memory.RAM.ReadU32(this.pointer + 0x24);
        }
        
        private void _field_0x24(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x24, value);
        }
    }
}
