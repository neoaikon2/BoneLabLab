using System;
 
using System.Collections.Generic;
using System.Linq;
 
 
using UnityEditor;
using UnityEngine;

namespace SLZ.MarrowEditor
{
    public static class MarrowProjectValidation
    {
        [Serializable]
        public class MarrowValidationRule
        {
            public int order = 10;
            public string message;
            public Func<bool> Validate;
            public Action FixRule;
            public string fixMessage;
        }

        private static float initialTime = 0;
        static MarrowProjectValidation()
        {
            EditorApplication.update -= WaitToDoInitialLoad;
            EditorApplication.update += WaitToDoInitialLoad;
        }

        private static void WaitToDoInitialLoad()
        {
            if (initialTime == 0)
            {
                initialTime = Time.realtimeSinceStartup;
            }
            else
            {
                float currentTime = Time.realtimeSinceStartup;
                if (currentTime - initialTime > 1)
                {
                    InitialLoadValidate();
                    EditorApplication.update -= WaitToDoInitialLoad;
                }
            }
        }

        private static void InitialLoadValidate()
        {
            bool autoFixRules = !ValidateProject();
#if false
#endif
            if (autoFixRules)
            {
                var issues = new List<MarrowValidationRule>();
                GetIssues(issues);
                if (issues.Count > 0)
                {
                    FixIssues(issues);
                }
            }
        }

        private static List<MarrowValidationRule> _validationRules = new List<MarrowValidationRule>();
        public static List<MarrowValidationRule> ValidationRules { get => _validationRules; }

        public static bool ValidateProject()
        {
            bool valid = true;
            foreach (var rule in ValidationRules)
            {
                try
                {
                    valid &= rule.Validate();
                }
                catch (Exception e)
                {
                    Debug.LogError($"MarrowProjectValidation: Failed to run validation on \"{rule.message}\"");
                    Debug.LogException(e);
                    valid = false;
                }
            }

            return valid;
        }

        public static void GetIssues(List<MarrowValidationRule> issues)
        {
            issues ??= new List<MarrowValidationRule>();
            issues.Clear();
            foreach (var rule in ValidationRules)
            {
                try
                {
                    if (!rule.Validate())
                        issues.Add(rule);
                }
                catch (Exception e)
                {
                    Debug.LogError($"MarrowProjectValidation: Failed to run validation on \"{rule.message}\"");
                    Debug.LogException(e);
                }
            }

            var sortedIssues = issues.OrderBy((rule) => rule.order).ToList();
            issues.Clear();
            foreach (var sortedIssue in sortedIssues)
            {
                issues.Add(sortedIssue);
            }
        }

        public static void FixIssues(List<MarrowValidationRule> issues)
        {
            EditorUtility.DisplayProgressBar("Marrow Project Setup", "Setting up Project Settings...", 1f / 10f);
            if (issues != null)
            {
                float count = 0;
                foreach (var issue in issues)
                {
                    EditorUtility.DisplayProgressBar("Marrow Project Setup", $"Setting up Project Settings: {issue.fixMessage}", count++ / issues.Count);
                    try
                    {
                        issue.FixRule();
                    }
                    catch (Exception e)
                    {
                        Debug.LogError($"MarrowProjectValidation: Failed to run fix validation on \"{issue.message}\"");
                        Debug.LogException(e);
                    }
                }
            }

            EditorUtility.ClearProgressBar();
        }
    }
}