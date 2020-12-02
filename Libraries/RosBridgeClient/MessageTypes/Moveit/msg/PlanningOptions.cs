/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class PlanningOptions : Message
    {
        public override string RosMessageName => "moveit_msgs/PlanningOptions";

        //  The diff to consider for the planning scene (optional)
        public PlanningScene planning_scene_diff { get; set; }
        //  If this flag is set to true, the action
        //  returns an executable plan in the response but does not attempt execution  
        public bool plan_only { get; set; }
        //  If this flag is set to true, the action of planning &
        //  executing is allowed to look around  (move sensors) if
        //  it seems that not enough information is available about
        //  the environment
        public bool look_around { get; set; }
        //  If this value is positive, the action of planning & executing
        //  is allowed to look around for a maximum number of attempts;
        //  If the value is left as 0, the default value is used, as set
        //  with dynamic_reconfigure
        public int look_around_attempts { get; set; }
        //  If set and if look_around is true, this value is used as
        //  the maximum cost allowed for a path to be considered executable.
        //  If the cost of a path is higher than this value, more sensing or 
        //  a new plan needed. If left as 0.0 but look_around is true, then 
        //  the default value set via dynamic_reconfigure is used
        public double max_safe_execution_cost { get; set; }
        //  If the plan becomes invalidated during execution, it is possible to have
        //  that plan recomputed and execution restarted. This flag enables this
        //  functionality 
        public bool replan { get; set; }
        //  The maximum number of replanning attempts 
        public int replan_attempts { get; set; }
        //  The amount of time to wait in between replanning attempts (in seconds)
        public double replan_delay { get; set; }

        public PlanningOptions()
        {
            this.planning_scene_diff = new PlanningScene();
            this.plan_only = false;
            this.look_around = false;
            this.look_around_attempts = 0;
            this.max_safe_execution_cost = 0.0;
            this.replan = false;
            this.replan_attempts = 0;
            this.replan_delay = 0.0;
        }

        public PlanningOptions(PlanningScene planning_scene_diff, bool plan_only, bool look_around, int look_around_attempts, double max_safe_execution_cost, bool replan, int replan_attempts, double replan_delay)
        {
            this.planning_scene_diff = planning_scene_diff;
            this.plan_only = plan_only;
            this.look_around = look_around;
            this.look_around_attempts = look_around_attempts;
            this.max_safe_execution_cost = max_safe_execution_cost;
            this.replan = replan;
            this.replan_attempts = replan_attempts;
            this.replan_delay = replan_delay;
        }
    }
}
