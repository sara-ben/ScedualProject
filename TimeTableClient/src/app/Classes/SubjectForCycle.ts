export class SubjectForCycle{
constructor( 
    public Id: number,
    public IdCycle: number,
    public idSubject: number,
    public NumberOfLessonsPerWeek: number,
    public idTeacher: number){}
}

export class IscedualValidate{
    constructor(
        public  teacherName: number,
        public  numHourDif: number
    ){}
}


