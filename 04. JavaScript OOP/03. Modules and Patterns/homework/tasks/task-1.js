/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {

  function validateTitle(title) {
    if (/^\s/.test(title) || /\s$/.test(title) || /\s\s+/g.test(title) || title === '') {
      return false;
    }
    else return true;
  }

  function validatePresentations(pres) {
    if (pres === null ||
      pres === undefined ||
      pres.length === 0 ||
      pres.some(x => !validateTitle(x))) {
      throw 'No presentations';
    }

  }

  function validateNames(firstAndLast) {
    var names = firstAndLast.split(' ');
    if (names.length > 2) {
      throw 'error';
    }
    function validateName(name) {
      if (!/^[A-Z][a-z]*$/.test(name)) {
        throw 'Invalid name';
      }
    }
    validateName(names[0]);
    validateName(names[1]);
  }

  function validateID(value, collection) {
    if (value > collection || value <= 0) {
      throw 'error';
    }
  }

  var Course = {

    init: function (title, presentations) {
      if (!validateTitle(title)) {
        throw 'Invalid title';
      };
      validatePresentations(presentations);
      this.students = [];
      this.presentations = presentations;
      return this;
    },
    addStudent: function (name) {
      validateNames(name);
      let names = name.split(' ');
      let firstName = names[0];
      let lastName = names[1];
      let studentId = this.students.length + 1;
      this.students.push({
        firstName: firstName,
        lastName: lastName,
        id: studentId,
        score: 0,
        homeworks: 0,
        finalScore: 0
      })
      return studentId;
    },
    getAllStudents: function () {
      newArr = this.students.map(x => ({ firstname: x.firstName, lastname: x.lastName, id: x.id, finalScore: x.score * 0.75 + (x.homeworks / this.presentations.length) * 0.25 }));
      return newArr;
    },
    submitHomework: function (studentID, homeworkID) {
      validateID(studentID, this.students.length);
      validateID(homeworkID, this.presentations.length);
      this.students[studentID - 1].homeworks += 1;
    },
    pushExamResults: function (results) {
      let currCourse = this;
      results.forEach(function (result) {
        validateID(result.StudentID, currCourse.length);
        if (isNaN(result.score)) throw 'Errorec';
        if (currCourse.students[result.StudentID - 1].score !== 0) throw 'Cheater';
        currCourse.students[result.StudentID - 1].score = result.score;
      })
    },
    getTopStudents: function () {
      let finalArr = this.getAllStudents();
      finalArr.sort((a, b) => a.finalScore < b.finalScore);
      for (let i = 0; i < Math.min(10, finalArr.length); i += 1) {
        console.log(finalArr[i]);
      }
    }
  };

  return Course;
}


module.exports = solve;
