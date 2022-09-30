using System.Collections.ObjectModel;

namespace ChildNodesPath {

    public class BaseObject {
        public string Name { get; set; }
        public string Executor { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public override string ToString() { return Name; }
    }

    public class ProjectObject : BaseObject { }

    public class Task : BaseObject {
        public string State { get; set; }
    }

    public class ViewModel {
        public ObservableCollection<ProjectObject> DataItems { get; set; }

        public ViewModel() {
            DataItems = InitData();
        }

        private ObservableCollection<ProjectObject> InitData() {
            ObservableCollection<ProjectObject> projects = new ObservableCollection<ProjectObject>();
            ProjectObject betaronProject = new ProjectObject() { Name = "Project: Betaron", Tasks = new ObservableCollection<Task>() };
            ProjectObject stantoneProject = new ProjectObject() { Name = "Project: Stanton", Tasks = new ObservableCollection<Task>() };

            InitBetaronProjectData(betaronProject);
            InitStantoneProjectData(stantoneProject);

            projects.Add(betaronProject);
            projects.Add(stantoneProject);

            return projects;
        }

        void InitBetaronProjectData(ProjectObject betaronProject) {
            betaronProject.Executor = "Mcfadyen Ball";
            Task Task11 = new Task() { Name = "Information Gathering", Executor = "Kaiden Savastano", Tasks = new ObservableCollection<Task>() };
            Task11.Tasks.Add(new Task() { Name = "Market research", Executor = "Carmine Then", State = "Completed" });
            Task11.Tasks.Add(new Task() { Name = "Making specification", Executor = "Seto Kober", State = "In progress" });

            Task Task12 = new Task() { Name = "Planning", Executor = "Manley Difrancesco", Tasks = new ObservableCollection<Task>() };
            Task12.Tasks.Add(new Task() { Name = "Documentation", Executor = "Martez Gollin", State = "Not started" });

            Task Task13 = new Task() { Name = "Design", Executor = "Clint Mary", Tasks = new ObservableCollection<Task>() };
            Task13.Tasks.Add(new Task() { Name = "Design of a web pages", Executor = "Gasper Hartsell", State = "Not started" });
            Task13.Tasks.Add(new Task() { Name = "Pages layout", Executor = "Shirish Huminski", State = "Not started" });

            betaronProject.Tasks.Add(Task11);
            betaronProject.Tasks.Add(Task12);
            betaronProject.Tasks.Add(Task13);

        }

        void InitStantoneProjectData(ProjectObject stantoneProject) {
            stantoneProject.Executor = "Ruben Ackerman";
            Task Task21 = new Task() { Name = "Information Gathering", Executor = "Huyen Trinklein", Tasks = new ObservableCollection<Task>() };
            Task21.Tasks.Add(new Task() { Name = "Market research", Executor = "Tanner Crittendon", State = "Completed" });
            Task21.Tasks.Add(new Task() { Name = "Making specification", Executor = "Carmine Then", State = "Completed" });

            Task Task22 = new Task() { Name = "Planning", Executor = "Alfredo Sookoo", Tasks = new ObservableCollection<Task>() };
            Task22.Tasks.Add(new Task() { Name = "Documentation", Executor = "Gorf Wobbe", State = "Completed" });

            Task Task23 = new Task() { Name = "Design", Executor = "Saphire Plump", Tasks = new ObservableCollection<Task>() };
            Task23.Tasks.Add(new Task() { Name = "Design of a web pages", Executor = "Dominic Minden", State = "In progress" });
            Task23.Tasks.Add(new Task() { Name = "Pages layout", Executor = "Pinkerton Trezise", State = "In progress" });

            Task Task24 = new Task() { Name = "Development", Executor = "Lauren Partain", Tasks = new ObservableCollection<Task>() };
            Task24.Tasks.Add(new Task() { Name = "Design", Executor = "Delilah Beamer", State = "In progress" });
            Task24.Tasks.Add(new Task() { Name = "Coding", Executor = "Dunaway Dupriest", State = "Not started" });

            stantoneProject.Tasks.Add(Task21);
            stantoneProject.Tasks.Add(Task22);
            stantoneProject.Tasks.Add(Task23);
            stantoneProject.Tasks.Add(Task24);
        }
    }
}
