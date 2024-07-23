export class ResultTbl{
    constructor(
        public id: number, 
        public idTeacher: number, 
        public idSubject: number, 
        public idGrade: number, 
        public idLesson: number, 
        //הוספה שלי: שם מורה
        public teacherName: string,
        //תוספת שלי: אי די יום
        public dayId: number,
        //תוספת שלי: אי די שעה
        public houerId: number,
        public numSortHouer:number,
        public isEditable: boolean,
        ){
        
    }
}