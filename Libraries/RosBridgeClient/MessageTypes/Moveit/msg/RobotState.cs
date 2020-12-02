/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Sensor;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class RobotState : Message
    {
        public override string RosMessageName => "moveit_msgs/RobotState";

        //  This message contains information about the robot state, i.e. the positions of its joints and links
        public JointState joint_state { get; set; }
        //  Joints that may have multiple DOF are specified here
        public MultiDOFJointState multi_dof_joint_state { get; set; }
        //  Attached collision objects (attached to some link on the robot)
        public AttachedCollisionObject[] attached_collision_objects { get; set; }
        //  Flag indicating whether this scene is to be interpreted as a diff with respect to some other scene
        //  This is mostly important for handling the attached bodies (whether or not to clear the attached bodies
        //  of a moveit::core::RobotState before updating it with this message)
        public bool is_diff { get; set; }

        public RobotState()
        {
            this.joint_state = new JointState();
            this.multi_dof_joint_state = new MultiDOFJointState();
            this.attached_collision_objects = new AttachedCollisionObject[0];
            this.is_diff = false;
        }

        public RobotState(JointState joint_state, MultiDOFJointState multi_dof_joint_state, AttachedCollisionObject[] attached_collision_objects, bool is_diff)
        {
            this.joint_state = joint_state;
            this.multi_dof_joint_state = multi_dof_joint_state;
            this.attached_collision_objects = attached_collision_objects;
            this.is_diff = is_diff;
        }
    }
}
