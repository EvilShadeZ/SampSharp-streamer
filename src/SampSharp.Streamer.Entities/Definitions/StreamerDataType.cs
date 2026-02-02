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

namespace SampSharp.Streamer.Entities
{
    /// <summary>
    /// Contains types of data to be used in Data Manipulation functions <see href="http://stackoverflow.com">https://github.com/samp-incognito/samp-streamer-plugin/wiki/Natives-(Data-Manipulation)</see>
    /// </summary>
    public enum StreamerDataType
    {
        //Suppressing warning to keep the enum names consistent with the streamer names.
        #pragma warning disable CA1707 // Identifiers should not contain underscores


        /// <summary>
        /// Area ID
        /// </summary>
        E_STREAMER_AREA_ID,

        /// <summary>
        /// Attached Object
        /// </summary>
        E_STREAMER_ATTACHED_OBJECT,
        /// <summary>
        /// Attached Player
        /// </summary>
        E_STREAMER_ATTACHED_PLAYER,
        /// <summary>
        /// Attached Vehicle
        /// </summary>
        E_STREAMER_ATTACHED_VEHICLE,
        /// <summary>
        /// Attached offset X
        /// </summary>
        E_STREAMER_ATTACH_OFFSET_X,
        /// <summary>
        /// Attached offset Y
        /// </summary>
        E_STREAMER_ATTACH_OFFSET_Y,
        /// <summary>
        /// Attached offset Z
        /// </summary>
        E_STREAMER_ATTACH_OFFSET_Z,
        /// <summary>
        /// Attached Rotation X
        /// </summary>
        E_STREAMER_ATTACH_R_X,
        /// <summary>
        /// Attached Rotation Y
        /// </summary>
        E_STREAMER_ATTACH_R_Y,
        /// <summary>
        /// Attached Rotation Z
        /// </summary>
        E_STREAMER_ATTACH_R_Z,
        /// <summary>
        /// Attached X
        /// </summary>
        E_STREAMER_ATTACH_X,
        /// <summary>
        /// Attached Y
        /// </summary>
        E_STREAMER_ATTACH_Y,
        /// <summary>
        /// Attached Z
        /// </summary>
        E_STREAMER_ATTACH_Z,
        /// <summary>
        /// Color
        /// </summary>
        E_STREAMER_COLOR,
        /// <summary>
        /// Draw Distance
        /// </summary>
        E_STREAMER_DRAW_DISTANCE,
        /// <summary>
        /// Extra ID
        /// </summary>
        E_STREAMER_EXTRA_ID,
        /// <summary>
        /// Health
        /// </summary>
        E_STREAMER_HEALTH,
        /// <summary>
        /// Interior ID
        /// </summary>
        E_STREAMER_INTERIOR_ID,
        /// <summary>
        /// Actor invulnerable
        /// </summary>
        E_STREAMER_INVULNERABLE,
        /// <summary>
        /// Area Max X
        /// </summary>
        E_STREAMER_MAX_X,
        /// <summary>
        /// Area Max Y
        /// </summary>
        E_STREAMER_MAX_Y,
        /// <summary>
        /// Area Max Z
        /// </summary>
        E_STREAMER_MAX_Z,
        /// <summary>
        /// Area Min X
        /// </summary>
        E_STREAMER_MIN_X,
        /// <summary>
        /// Area Min Y
        /// </summary>
        E_STREAMER_MIN_Y,
        /// <summary>
        /// Area Min Z
        /// </summary>
        E_STREAMER_MIN_Z,
        /// <summary>
        /// Model ID
        /// </summary>
        E_STREAMER_MODEL_ID,
        /// <summary>
        /// Object Move Rotation X
        /// </summary>
        E_STREAMER_MOVE_R_X,
        /// <summary>
        /// Object Move Rotation Y
        /// </summary>
        E_STREAMER_MOVE_R_Y,
        /// <summary>
        /// Object Move Rotation Z
        /// </summary>
        E_STREAMER_MOVE_R_Z,
        /// <summary>
        /// Object Move Speed
        /// </summary>
        E_STREAMER_MOVE_SPEED,
        /// <summary>
        /// Object Move X
        /// </summary>
        E_STREAMER_MOVE_X,
        /// <summary>
        /// Object Move Y
        /// </summary>
        E_STREAMER_MOVE_Y,
        /// <summary>
        /// Object Move Z
        /// </summary>
        E_STREAMER_MOVE_Z,
        /// <summary>
        /// Next X
        /// </summary>
        E_STREAMER_NEXT_X,
        /// <summary>
        /// Next Y
        /// </summary>
        E_STREAMER_NEXT_Y,
        /// <summary>
        /// Next Z
        /// </summary>
        E_STREAMER_NEXT_Z,
        /// <summary>
        /// Streamer Player ID
        /// </summary>
        E_STREAMER_PLAYER_ID,
        /// <summary>
        /// Streamer Priority
        /// </summary>
        E_STREAMER_PRIORITY,
        /// <summary>
        /// Rotation
        /// </summary>
        E_STREAMER_ROTATION,
        /// <summary>
        /// Rotation X
        /// </summary>
        E_STREAMER_R_X,
        /// <summary>
        /// Rotation Y
        /// </summary>
        E_STREAMER_R_Y,
        /// <summary>
        /// Rotation Z
        /// </summary>
        E_STREAMER_R_Z,
        /// <summary>
        /// Size
        /// </summary>
        E_STREAMER_SIZE,
        /// <summary>
        /// Stream Distance
        /// </summary>
        E_STREAMER_STREAM_DISTANCE,
        /// <summary>
        /// Style
        /// </summary>
        E_STREAMER_STYLE,
        /// <summary>
        /// Sync Rotation
        /// </summary>
        E_STREAMER_SYNC_ROTATION,
        /// <summary>
        /// Test Line Of Sight
        /// </summary>
        E_STREAMER_TEST_LOS,
        /// <summary>
        /// Streamer Type
        /// </summary>
        E_STREAMER_TYPE,
        /// <summary>
        /// Virtual World
        /// </summary>
        E_STREAMER_WORLD_ID,
        /// <summary>
        /// Position X
        /// </summary>
        E_STREAMER_X,
        /// <summary>
        /// Position Y
        /// </summary>
        E_STREAMER_Y,
        /// <summary>
        /// Position Z
        /// </summary>
        E_STREAMER_Z
#pragma warning restore CA1707 // Identifiers should not contain underscores
    }
}
