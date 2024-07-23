import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Constrains } from 'src/app/Classes/Constrains';
import { Day } from 'src/app/Classes/Day';
import { Grade } from 'src/app/Classes/Grade';
import { Houer } from 'src/app/Classes/Houer';
import { Lesson } from 'src/app/Classes/Lesson';
import { ResultTbl } from 'src/app/Classes/Result';
import { IscedualValidate, SubjectForCycle } from 'src/app/Classes/SubjectForCycle';
import { Teacher } from 'src/app/Classes/Teacher';
import { ConstrainsService } from 'src/app/Services/constrains.service';
import { DayService } from 'src/app/Services/day.service';
import { GradeService } from 'src/app/Services/grade.service';
import { HourService } from 'src/app/Services/hour.service';
import { LessonService } from 'src/app/Services/lesson.service';
import { ResultService } from 'src/app/Services/result.service';
import { SubjectForCycleService } from 'src/app/Services/subject-for-cycle.service';
import { SubjectService } from 'src/app/Services/subject.service';
import { TeacherService } from 'src/app/Services/teacher.service';
import { Subject } from 'src/app/Classes/Subject';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-edit-schedual',
  templateUrl: './edit-schedual.component.html',
  styleUrls: ['./edit-schedual.component.css']
})
export class EditSchedualComponent implements OnInit {

  constructor(private gradeService: GradeService,
    private dayService: DayService,
    private hourService: HourService,
    private resultService: ResultService,
    private teacherService: TeacherService,
    private lessonService: LessonService,
    private constrainsService: ConstrainsService,
    private subjectForCycleService: SubjectForCycleService,
    private subjectService: SubjectService) { }

  allGrades: Array<Grade> = new Array<Grade>;
  allDays: Array<Day> = new Array<Day>;
  allHouers: Array<Houer> = new Array<Houer>;
  allResults: Array<ResultTbl> = new Array<ResultTbl>;
  selectedGradeName: string | undefined;
  // selectedGrade: Grade | undefined;
  scedualPerGrade: Array<ResultTbl> = new Array<ResultTbl>;
  allTeachers: Array<Teacher> = new Array<Teacher>();
  allLessons: Array<Lesson> = new Array<Lesson>();
  isScedualPerGradeSorted: boolean = false;
  i: number = 0;
  isEditableUpdated: boolean = false;
  allConstrains: Array<Constrains> = new Array<Constrains>();
  allSubjectForCycle: Array<SubjectForCycle> = new Array<SubjectForCycle>();
  flag: boolean = false;
  scedualPerGradeMakor: Array<ResultTbl> = new Array<ResultTbl>();
  oldResult: ResultTbl | undefined;
  selectedGrade: Grade = new Grade(0, '', 0);
  scedualValidateList: Array<IscedualValidate> = new Array<IscedualValidate>();
  res: ResultTbl = new ResultTbl(0, 0, 0, 0, 0, "", 0, 0, 0, true);
  x: number = 0;
  y: number = 0;
  allSubjects: Array<Subject> = new Array<Subject>;
  isSchedualCheked: boolean = false;
  ngOnInit(): void {
    this.gradeService.getAllGrade().subscribe(data => {
      this.allGrades = data;
      this.gradeService.gradeList = data;
      this.constrainsService.getAllallConstrains().subscribe(data => {
        this.allConstrains = data;
        this.dayService.getAllDays().subscribe(data => {
          this.allDays = data;
          this.dayService.dayList = data;
          this.hourService.getAllHouer().subscribe(data => {
            this.allHouers = data;
            this.hourService.houerList = data;
            this.resultService.getAllResult().subscribe(data => {
              this.allResults = data;
              this.resultService.resultList = data;
              this.teacherService.getAllTeacher().subscribe(data => {
                this.allTeachers = data;
                this.teacherService.teacherList = data;
                this.lessonService.getAllLessons().subscribe(data => {
                  this.allLessons = data;
                  this.lessonService.lessonList = data;
                  this.subjectForCycleService.getAllSubjectForCycle().subscribe(data => {
                    this.allSubjectForCycle = data;
                    this.subjectService.getAllSubject().subscribe(data => {
                      this.allSubjects = data;
                      this.getTeacherNameByResults();
                      this.addHouerIdToResultModel();
                      this.addDayIdToResultModel();
                    },);
                  },);
                },);
              },);
            },);
          },);
        },);

      },);

    },);

  }

  sortAllHouers() {
    //numSort לסדר את המערך של השעות לפי ;
    this.allHouers.sort(function (a, b) { return a.numSort - b.numSort });
  }

  sortScedualPerGrade() {
    this.scedualPerGrade.sort(function (a, b) { return (a.dayId - b.dayId || a.numSortHouer - b.numSortHouer) });
    this.isScedualPerGradeSorted = true;
    this.scedualPerGradeMakor = structuredClone(this.scedualPerGrade);
  }

  getSchedulePerClass() {
    //מציאת הכיתה שנבחרה
    this.sortAllHouers()
    //ריקון המערך מפעם הקודמת
    this.scedualPerGrade = new Array<ResultTbl>()
    this.isScedualPerGradeSorted = false;

    this.allGrades.forEach(item => {
      if (item.name == this.selectedGradeName) {
        this.selectedGrade = item;
        console.log(item);
        this.gradeService.selectedGrade = item;
      }
    })


    //מציאת כל השעורים של הכיתה שנבחרה
    this.allResults.forEach(item => {
      if (item.idGrade == this.selectedGrade?.id) {
        this.scedualPerGrade.push(item)
      }
    })

    //להציג את המערכת של כל הימים וכל השעות 

    this.addNumSortHouuerToResultModel();

    this.sortScedualPerGrade();
    console.log(this.scedualPerGrade);
  }

  getTeacherNameByResults() {
    //כאן עברתי על כל השיעורים והוספתי להם את השם של המורה לפי ה אי די של המורה
    this.allResults.forEach(result => {
      this.allTeachers.forEach(teacher => {
        if (result.idTeacher == teacher.id) {
          result.teacherName = teacher.name;
        }
      })
    })
  }

  addDayIdToResultModel() {
    //כאן עברתי על כל התוצאות והוספתי להם אי די של יום לפי  ה אי די של שעור
    this.allResults.forEach(result => {
      this.allLessons.forEach(lesson => {
        if (result.idLesson == lesson.id) {
          result.dayId = lesson.idDay;
        }
      })
    })
  }
  addNumSortHouuerToResultModel() {
    //כאן עברתי על כל התוצאות והוספתי להם אי די של יום לפי  ה אי די של שעור
    this.scedualPerGrade.forEach(result => {
      this.allHouers.forEach(houer => {
        if (result.houerId == houer.id) {
          result.numSortHouer = houer.numSort * (result.dayId);
        }
      })
    })

    // })

  }
  addHouerIdToResultModel() {
    //כאן עברתי על כל התוצאות והוספתי להם אי די של יום לפי  ה אי די של שעור
    this.allResults.forEach(result => {
      this.allLessons.forEach(lesson => {
        if (result.idLesson == lesson.id) {
          result.houerId = lesson.idHour;
        }
      })
      this.allResults.forEach(subject => {
        if (subject.id == result.id) {
          result.isEditable = subject.isEditable;
        }
      })
    })
    this.isEditableUpdated = true;
  }



  checkTheScedual() 
  {
    let duplicalInScedual = '';
    this.resultService.chekAllResults(this.allResults).subscribe(data => {
      console.log("duplicated", data);
      data.forEach(d => {
        let grades = '';
        for (let i = 0; i < d.grades.length; i++) 
        { 
          grades += `${this.allGrades[ d.grades[i]-1].name}, `; 
        }
        // ${this.allLessons[d.lessonId].idHour - 1} שעור מספר 
        duplicalInScedual += ` המורה ${this.allTeachers[d.teacherId - 1].name} משובצת ביום ${this.allDays[this.allLessons[d.lessonId].idDay - 1]?.name}  בו זמנית בכיתות ${grades}<br>`;

      })

    // })
    if (duplicalInScedual != '')
      Swal.fire(duplicalInScedual, "", "error");
    else {
      Swal.fire("מערכת תקינה !", "", "success");
      this.isSchedualCheked = true;
    }


  })

}
checkResult(result: ResultTbl, teacher: Teacher){
  this.scedualPerGradeMakor[result.id] = this.scedualPerGrade[result.id];
  this.flag = false;
  this.allConstrains.forEach(constrain => {
    if (constrain.idDay == result.dayId &&
      constrain.idTeacher == teacher.id &&
      constrain.idHour == result.houerId) {
      this.flag = true;

    }
  })
  if (!this.flag) {
    Swal.fire('', " המורה " + teacher.name + " לא יכולה ביום " + this.allDays[result.dayId].name + " בשעור מספר  " + result.houerId, 'error');

    teacher.name = result.teacherName;
    return false;
  }

  this.x = this.scedualPerGrade.findIndex(e => e.id === result.id);
  this.scedualPerGrade[this.x].idTeacher = teacher.id;
  this.scedualPerGrade[this.x].teacherName = teacher.name;
  this.y = this.allSubjectForCycle.findIndex(s => s.idTeacher == teacher.id);
  this.scedualPerGrade[this.x].idSubject = this.allSubjectForCycle[this.y].idSubject;
  console.log("sc", this.scedualPerGrade)

  return true;
}

ChekScedualPerClass(selectedGrade: Grade){
  console.log("sc", this.scedualPerGrade)

  this.subjectForCycleService.chekScedualBySubjectAmount(this.scedualPerGrade, this.selectedGrade.idCycle).subscribe(data => {
    console.log(data);
    let errorInScedual = '';
    data.forEach(d => {
      if (d.teacherName != 27 && d.teacherName != 28) {
        if (d.numHourDif > 0) {
          errorInScedual += ` המורה ${this.allTeachers[d.teacherName - 1].name} משובצת ב ${d.numHourDif} שעורים מיותרים <br>`;
          // alert(" המורה "+this.allTeachers[d.teacherName-1].name +" משובצת ב "+ d.numHourDif +" שעורים מיותרים"  );
          // Swal.fire("מערכת לא תקינה ", "You clicked the button!", "error");

        }
        else {
          errorInScedual += ` המורה ${this.allTeachers[d.teacherName - 1].name} צריכה להיות משובצת בעוד ${Math.abs(d.numHourDif)} שעורים <br>`;
          // alert(" המורה "+this.allTeachers[d.teacherName-1].name +" צריכה להיות משובצת בעוד " + Math.abs(d.numHourDif) +" שעורים " );
        }
      }

    })
    Swal.fire(errorInScedual, "", "error")
    //  this.scedualValidateList=data;
    if (data.length == 0) {
      //{{this.selectedGrade.name}}
      Swal.fire(`מערכת תקינה עבור כיתה ${this.selectedGrade.name} !`, "", "success");

      // Swal.fire("מערכת תקינה עבור כיתה!","", "success");

      // Swal.fire("מערכת לא תקינה ", "You clicked the button!", "error");
      // console.log(": " ,this.scedualValidateList)
    }

  });


}

saveScedual(){
  if (this.isSchedualCheked) {
    this.resultService.editSchedual(this.allResults).subscribe(data => {
      Swal.fire("המערכת נשמרה!", "", "success");
    })
  }
  else {
    Swal.fire("יש לבדוק את המערכת ולוודא את תקינותה לפני השמירה", "", "warning");

  }
}
    
    }


