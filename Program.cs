using System;

namespace Operations_decisions_loops
{
  
    class Program
    {
        static float partialEvaluationWorkInClass = 0.25f;
        static float partialEvaluationPractices = 0.25f;
        static float partialEvaluationParticipation = 0.10f;
        static float partialEvaluationProject = 0.40f;

        static float semesterEvaluationWorkInClass = 0.15f;
        static float semesterEvaluationPractices = 0.20f;
        static float semesterEvaluationParticipation = 0.05f;
        static float semesterEvaluationProject = 0.60f;

        static float semesterResultPassThreshold = 6f;

          static float semesterResultAvailable = 12f;
	static float PartialEvaluation(float workInClass, float practice, float Participación, float Project)
        {
            //Se recomienda ampliamente que los métodos en C# empiecen con mayúscula
            //Evaluación parcial
            //Trabajo en clase 25
            //Practicas 25
            //Participación/Esfuerzo 10
            //Proyecto 40
            //Evaluación parcial
            //Trabajo en clase 15
            //Practicas 20
            //Participación/Esfuerzo 5
            //Proyecto 60

            float partialResult =workInClass * partialEvaluationWorkInClass
            + practice * partialEvaluationPractices + Participación * partialEvaluationParticipation + Project * partialEvaluationProject;
            //return 0.0f;
            return partialResult;
        }
          static float semesterEvaluation(float workInClass, float practice, float Participación, float Project) {
              float semesterResult = workInClass * semesterEvaluationWorkInClass
            + practice * semesterEvaluationPractices + Participación * semesterEvaluationParticipation + Project * semesterEvaluationProject;
            return semesterResult;
          }
	static void Main(string[] args)
        {

            float partial1Result;
            float partial2Result;
            float semesterResult;

           /*  partial1Result = 10 * partialEvaluationWorkInClass
            + 10 * partialEvaluationPractices + 10 * partialEvaluationParticipation + 10 * partialEvaluationProject;
            Console.WriteLine("partial1Result = " + partial1Result);
            partial2Result = 10 * partialEvaluationWorkInClass
            + 10 * partialEvaluationPractices + 10 * partialEvaluationParticipation + 10 * partialEvaluationProject;
            Console.WriteLine("partial2Result = " + partial2Result);
            semesterResult = 10 * semesterEvaluationWorkInClass
            + 10 * semesterEvaluationPractices + 10 * semesterEvaluationParticipation + 10 * semesterEvaluationProject;
            Console.WriteLine("semesterResult = " + semesterResult); */

            partial1Result = PartialEvaluation(3f, 1f, 2f, 6f);
               Console.WriteLine("partial1Result =" + partial1Result);

          partial2Result = PartialEvaluation(10f, 8f, 9f, 10f);

          Console.WriteLine("partial2Result =" + partial2Result);

          if(partial1Result + partial2Result >= semesterResultAvailable){
               semesterResult = semesterEvaluation(8f, 9f, 10f, 10f);
          }
               else{
                    semesterResult =0f;
               }
                    Console.WriteLine("resultado final =" + semesterResult);

                    Console.WriteLine("semesterResult =" + semesterResult);
                    if (semesterResult >= semesterResultPassThreshold){
                         Console.WriteLine("APROBADO");
                    }else {
                         Console.WriteLine("REPROBADO");
                    }

        }
    }
} 
