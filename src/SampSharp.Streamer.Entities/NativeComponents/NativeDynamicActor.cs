// SampSharp.Streamer
// Copyright 2020 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SampSharp.Core.Natives.NativeObjects;
using SampSharp.Entities.SAMP;

namespace SampSharp.Streamer.Entities
{
    public class NativeDynamicActor : BaseNativeComponent
    {
        /// <summary>
        /// Identifier indicating the handle is invalid.
        /// </summary>
        public const int InvalidId = 0x0;

        [NativeMethod]
        public virtual bool IsValidDynamicActor()
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual bool DestroyDynamicActor()
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int GetDynamicActorPos(out float x, out float y, out float z)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int SetDynamicActorPos(float x, float y, float z)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int GetDynamicActorVirtualWorld()
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int SetDynamicActorVirtualWorld(int vworld)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int ApplyDynamicActorAnimation(string animlib, string animname, float fdelta, int loop, int lockx, int locky, int freeze, int time)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int ClearDynamicActorAnimations()
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int GetDynamicActorFacingAngle(out float angle)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int SetDynamicActorFacingAngle(float angle)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int GetDynamicActorHealth(out float health)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int SetDynamicActorHealth(float health)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual int SetDynamicActorInvulnerable(int invulnerable)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod]
        public virtual bool IsDynamicActorInvulnerable()
        {
            throw new NativeNotImplementedException();
        }

    }
}
