
#nullable enable

namespace Fal
{
    /// <summary>
    /// Event category<br/>
    /// Example: deployment_started
    /// </summary>
    public enum ServerlessListAppEventsResponseEventCategory
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigChanged,
        /// <summary>
        /// 
        /// </summary>
        DeploymentEnded,
        /// <summary>
        /// 
        /// </summary>
        DeploymentFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRecreateApplied,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRollingEnded,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRollingFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRollingStarted,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStarted,
        /// <summary>
        /// 
        /// </summary>
        RunnerDockerPull,
        /// <summary>
        /// 
        /// </summary>
        RunnerDraining,
        /// <summary>
        /// 
        /// </summary>
        RunnerFailed,
        /// <summary>
        /// 
        /// </summary>
        RunnerFinished,
        /// <summary>
        /// 
        /// </summary>
        RunnerPending,
        /// <summary>
        /// 
        /// </summary>
        RunnerSetup,
        /// <summary>
        /// 
        /// </summary>
        RunnerStarted,
        /// <summary>
        /// 
        /// </summary>
        RunnerStartupFailure,
        /// <summary>
        /// 
        /// </summary>
        RunnerStopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListAppEventsResponseEventCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsResponseEventCategory value)
        {
            return value switch
            {
                ServerlessListAppEventsResponseEventCategory.ConfigChanged => "config_changed",
                ServerlessListAppEventsResponseEventCategory.DeploymentEnded => "deployment_ended",
                ServerlessListAppEventsResponseEventCategory.DeploymentFailed => "deployment_failed",
                ServerlessListAppEventsResponseEventCategory.DeploymentRecreateApplied => "deployment_recreate_applied",
                ServerlessListAppEventsResponseEventCategory.DeploymentRollingEnded => "deployment_rolling_ended",
                ServerlessListAppEventsResponseEventCategory.DeploymentRollingFailed => "deployment_rolling_failed",
                ServerlessListAppEventsResponseEventCategory.DeploymentRollingStarted => "deployment_rolling_started",
                ServerlessListAppEventsResponseEventCategory.DeploymentStarted => "deployment_started",
                ServerlessListAppEventsResponseEventCategory.RunnerDockerPull => "runner_docker_pull",
                ServerlessListAppEventsResponseEventCategory.RunnerDraining => "runner_draining",
                ServerlessListAppEventsResponseEventCategory.RunnerFailed => "runner_failed",
                ServerlessListAppEventsResponseEventCategory.RunnerFinished => "runner_finished",
                ServerlessListAppEventsResponseEventCategory.RunnerPending => "runner_pending",
                ServerlessListAppEventsResponseEventCategory.RunnerSetup => "runner_setup",
                ServerlessListAppEventsResponseEventCategory.RunnerStarted => "runner_started",
                ServerlessListAppEventsResponseEventCategory.RunnerStartupFailure => "runner_startup_failure",
                ServerlessListAppEventsResponseEventCategory.RunnerStopping => "runner_stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsResponseEventCategory? ToEnum(string value)
        {
            return value switch
            {
                "config_changed" => ServerlessListAppEventsResponseEventCategory.ConfigChanged,
                "deployment_ended" => ServerlessListAppEventsResponseEventCategory.DeploymentEnded,
                "deployment_failed" => ServerlessListAppEventsResponseEventCategory.DeploymentFailed,
                "deployment_recreate_applied" => ServerlessListAppEventsResponseEventCategory.DeploymentRecreateApplied,
                "deployment_rolling_ended" => ServerlessListAppEventsResponseEventCategory.DeploymentRollingEnded,
                "deployment_rolling_failed" => ServerlessListAppEventsResponseEventCategory.DeploymentRollingFailed,
                "deployment_rolling_started" => ServerlessListAppEventsResponseEventCategory.DeploymentRollingStarted,
                "deployment_started" => ServerlessListAppEventsResponseEventCategory.DeploymentStarted,
                "runner_docker_pull" => ServerlessListAppEventsResponseEventCategory.RunnerDockerPull,
                "runner_draining" => ServerlessListAppEventsResponseEventCategory.RunnerDraining,
                "runner_failed" => ServerlessListAppEventsResponseEventCategory.RunnerFailed,
                "runner_finished" => ServerlessListAppEventsResponseEventCategory.RunnerFinished,
                "runner_pending" => ServerlessListAppEventsResponseEventCategory.RunnerPending,
                "runner_setup" => ServerlessListAppEventsResponseEventCategory.RunnerSetup,
                "runner_started" => ServerlessListAppEventsResponseEventCategory.RunnerStarted,
                "runner_startup_failure" => ServerlessListAppEventsResponseEventCategory.RunnerStartupFailure,
                "runner_stopping" => ServerlessListAppEventsResponseEventCategory.RunnerStopping,
                _ => null,
            };
        }
    }
}