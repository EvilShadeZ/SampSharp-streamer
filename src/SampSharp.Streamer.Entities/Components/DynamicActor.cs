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

using System;
using System.Threading;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace SampSharp.Streamer.Entities
{
    /// <summary>
    /// Represents a component which provides the data and functionality of an dynamic actor.
    /// </summary>
    public sealed class DynamicActor : Component
    {
        private DynamicActor()
        {

        }

        /// <summary>
        /// Gets whether this dynamic actor is valid.
        /// </summary>
        public bool IsValid => GetComponent<NativeDynamicActor>().IsValidDynamicActor();

        /// <summary>
        /// Gets the position of this dynamic actor.
        /// </summary>
        public Vector3 Position
        {
            get
            {
                GetComponent<NativeDynamicActor>().GetDynamicActorPos(out var x, out var y, out var z);
                return new Vector3(x, y, z);
            }
            set => GetComponent<NativeDynamicActor>().SetDynamicActorPos(value.X, value.Y, value.Z);
        }

        /// <summary>
        /// Gets the rotation of this dynamic actor.
        /// </summary>
        public Vector3 Rotation
        {
            get
            {
                GetComponent<NativeDynamicActor>().GetDynamicActorFacingAngle(out var angle);
                return new Vector3(0, 0, angle);
            }
            set => GetComponent<NativeDynamicActor>().SetDynamicActorFacingAngle(value.Z);
        }
        /// <summary>
        /// Gets the facing angle of this dynamic actor.
        /// </summary>
        public float Angle
        {
            get
            {
                GetComponent<NativeDynamicActor>().GetDynamicActorFacingAngle(out var angle);
                return angle;
            }
            set => GetComponent<NativeDynamicActor>().SetDynamicActorFacingAngle(value);
        }
        /// <summary>
        /// Gets whether or not this actor is invulnerable
        /// </summary>
        public bool Invulnerable
        {
            get
            {
                return GetComponent<NativeDynamicActor>().IsDynamicActorInvulnerable();
            }
            set => GetComponent<NativeDynamicActor>().SetDynamicActorInvulnerable(value == true ? 1 : 0);
        }


        /// <summary>
        /// Gets the VirtualWorld of this dynamic actor.
        /// </summary>
        public int VirtualWorld
        {
            get
            {
                return GetComponent<NativeDynamicActor>().GetDynamicActorVirtualWorld();
            }
            set => GetComponent<NativeDynamicActor>().SetDynamicActorVirtualWorld(value);
        }

        /// <summary>Apply an animation to this actor.</summary>
        /// <param name="animationLibrary">The name of the animation library in which the animation to apply is in.</param>
        /// <param name="animationName">The name of the animation, within the library specified.</param>
        /// <param name="fDelta">The speed to play the animation (use 4.1).</param>
        /// <param name="loop">Set to True for looping otherwise set to False for playing animation sequence only once.</param>
        /// <param name="lockX">
        /// Set to False to return player to original x position after animation is complete for moving animations. The opposite effect occurs if set
        /// to True.
        /// </param>
        /// <param name="lockY">
        /// Set to False to return player to original y position after animation is complete for moving animations. The opposite effect occurs if set
        /// to True.
        /// </param>
        /// <param name="freeze">Will freeze the player in position after the animation finishes.</param>
        /// <param name="time">Timer in milliseconds. For a never ending loop it should be 0.</param>
        public void ApplyAnimation(string animationLibrary, string animationName, float fDelta, bool loop, bool lockX, bool lockY, bool freeze, int time)
        {
            GetComponent<NativeDynamicActor>()
                .ApplyDynamicActorAnimation(animationLibrary, animationName, fDelta, loop == true? 1 : 0, lockX == true ? 1 : 0, lockY == true ? 1 : 0, freeze == true ? 1 : 0, time);
        }

        /// <summary>Clears all animations for this actor.</summary>
        public void ClearAnimations()
        {
            GetComponent<NativeActor>()
                .ClearActorAnimations();
                
        }







        /// <inheritdoc />
        protected override void OnDestroyComponent()
        {
            GetComponent<NativeDynamicActor>().DestroyDynamicActor();
        }
    }
}