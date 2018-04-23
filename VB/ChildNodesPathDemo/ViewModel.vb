Imports System.Collections.ObjectModel

Namespace ChildNodesPathDemo

    Public Class BaseObject
        Public Property Name() As String
        Public Property Executor() As String
        Public Property Tasks() As ObservableCollection(Of Task)
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Class ProjectObject
        Inherits BaseObject

    End Class

    Public Class Task
        Inherits BaseObject

        Public Property State() As String
    End Class

    Public Class ViewModel
        Public Property DataItems() As ObservableCollection(Of ProjectObject)

        Public Sub New()
            DataItems = InitData()
        End Sub

        Private Function InitData() As ObservableCollection(Of ProjectObject)
            Dim projects As New ObservableCollection(Of ProjectObject)()
            Dim betaronProject As New ProjectObject() With { _
                .Name = "Project: Betaron", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Dim stantoneProject As New ProjectObject() With { _
                .Name = "Project: Stanton", _
                .Tasks = New ObservableCollection(Of Task)() _
            }

            InitBetaronProjectData(betaronProject)
            InitStantoneProjectData(stantoneProject)

            projects.Add(betaronProject)
            projects.Add(stantoneProject)

            Return projects
        End Function

        Private Sub InitBetaronProjectData(ByVal betaronProject As ProjectObject)
            betaronProject.Executor = "Mcfadyen Ball"
            Dim Task11 As New Task() With { _
                .Name = "Information Gathering", _
                .Executor = "Kaiden Savastano", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task11.Tasks.Add(New Task() With { _
                .Name = "Market research", _
                .Executor = "Carmine Then", _
                .State = "Completed" _
            })
            Task11.Tasks.Add(New Task() With { _
                .Name = "Making specification", _
                .Executor = "Seto Kober", _
                .State = "In progress" _
            })

            Dim Task12 As New Task() With { _
                .Name = "Planning", _
                .Executor = "Manley Difrancesco", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task12.Tasks.Add(New Task() With { _
                .Name = "Documentation", _
                .Executor = "Martez Gollin", _
                .State = "Not started" _
            })

            Dim Task13 As New Task() With { _
                .Name = "Design", _
                .Executor = "Clint Mary", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task13.Tasks.Add(New Task() With { _
                .Name = "Design of a web pages", _
                .Executor = "Gasper Hartsell", _
                .State = "Not started" _
            })
            Task13.Tasks.Add(New Task() With { _
                .Name = "Pages layout", _
                .Executor = "Shirish Huminski", _
                .State = "Not started" _
            })

            betaronProject.Tasks.Add(Task11)
            betaronProject.Tasks.Add(Task12)
            betaronProject.Tasks.Add(Task13)

        End Sub

        Private Sub InitStantoneProjectData(ByVal stantoneProject As ProjectObject)
            stantoneProject.Executor = "Ruben Ackerman"
            Dim Task21 As New Task() With { _
                .Name = "Information Gathering", _
                .Executor = "Huyen Trinklein", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task21.Tasks.Add(New Task() With { _
                .Name = "Market research", _
                .Executor = "Tanner Crittendon", _
                .State = "Completed" _
            })
            Task21.Tasks.Add(New Task() With { _
                .Name = "Making specification", _
                .Executor = "Carmine Then", _
                .State = "Completed" _
            })

            Dim Task22 As New Task() With { _
                .Name = "Planning", _
                .Executor = "Alfredo Sookoo", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task22.Tasks.Add(New Task() With { _
                .Name = "Documentation", _
                .Executor = "Gorf Wobbe", _
                .State = "Completed" _
            })

            Dim Task23 As New Task() With { _
                .Name = "Design", _
                .Executor = "Saphire Plump", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task23.Tasks.Add(New Task() With { _
                .Name = "Design of a web pages", _
                .Executor = "Dominic Minden", _
                .State = "In progress" _
            })
            Task23.Tasks.Add(New Task() With { _
                .Name = "Pages layout", _
                .Executor = "Pinkerton Trezise", _
                .State = "In progress" _
            })

            Dim Task24 As New Task() With { _
                .Name = "Development", _
                .Executor = "Lauren Partain", _
                .Tasks = New ObservableCollection(Of Task)() _
            }
            Task24.Tasks.Add(New Task() With { _
                .Name = "Design", _
                .Executor = "Delilah Beamer", _
                .State = "In progress" _
            })
            Task24.Tasks.Add(New Task() With { _
                .Name = "Coding", _
                .Executor = "Dunaway Dupriest", _
                .State = "Not started" _
            })

            stantoneProject.Tasks.Add(Task21)
            stantoneProject.Tasks.Add(Task22)
            stantoneProject.Tasks.Add(Task23)
            stantoneProject.Tasks.Add(Task24)
        End Sub
    End Class
End Namespace