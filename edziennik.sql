-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 18 Cze 2022, 16:33
-- Wersja serwera: 10.4.11-MariaDB
-- Wersja PHP: 7.2.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `edziennik`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `attendence`
--

CREATE TABLE `attendence` (
  `id` int(11) NOT NULL,
  `studentid` int(11) NOT NULL,
  `subjectid` int(11) NOT NULL,
  `datetime_present` datetime NOT NULL DEFAULT current_timestamp(),
  `present` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `attendence`
--

INSERT INTO `attendence` (`id`, `studentid`, `subjectid`, `datetime_present`, `present`) VALUES
(7, 2, 1, '2022-06-18 15:21:37', 1),
(9, 3, 1, '2022-03-18 12:00:00', 1),
(10, 3, 1, '2022-03-15 12:00:00', 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `mark`
--

CREATE TABLE `mark` (
  `id` int(11) NOT NULL,
  `studentid` int(11) NOT NULL,
  `taskid` int(11) NOT NULL,
  `value` float NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `mark`
--

INSERT INTO `mark` (`id`, `studentid`, `taskid`, `value`) VALUES
(1, 1, 11, 4),
(2, 2, 11, 5),
(3, 3, 11, 6),
(4, 3, 12, 3.5),
(6, 1, 15, 4);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `name` varchar(40) NOT NULL,
  `surname` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `student`
--

INSERT INTO `student` (`id`, `name`, `surname`) VALUES
(1, 'Adam', 'Wysocki'),
(2, 'Michał', 'Nowak'),
(3, 'Wiktor', 'Wiśniewski'),
(4, 'Andrzej', 'Anders');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `student_subject`
--

CREATE TABLE `student_subject` (
  `id` int(11) NOT NULL,
  `studentid` int(11) NOT NULL,
  `subjectid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `student_subject`
--

INSERT INTO `student_subject` (`id`, `studentid`, `subjectid`) VALUES
(1, 1, 1),
(2, 1, 3),
(3, 1, 4),
(4, 1, 6),
(5, 1, 9),
(6, 2, 1),
(7, 1, 3),
(8, 2, 5),
(9, 2, 7),
(10, 2, 8),
(11, 3, 1),
(12, 3, 3),
(13, 3, 4),
(14, 3, 7),
(15, 3, 9),
(16, 4, 1),
(17, 4, 6),
(18, 4, 7),
(19, 4, 8),
(20, 4, 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `subject`
--

CREATE TABLE `subject` (
  `id` int(11) NOT NULL,
  `name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `subject`
--

INSERT INTO `subject` (`id`, `name`) VALUES
(1, 'Matematyka'),
(3, 'Język polski'),
(4, 'Język angielski'),
(5, 'Język niemiecki'),
(6, 'Fizyka'),
(7, 'Chemia'),
(8, 'Biologa'),
(9, 'Wychowanie fizyczne');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `task`
--

CREATE TABLE `task` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL DEFAULT 'Nowe zadanie',
  `date_added` date NOT NULL DEFAULT current_timestamp(),
  `date_deadline` date NOT NULL,
  `teacherid` int(11) NOT NULL,
  `subjectid` int(11) NOT NULL,
  `task_type_id` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `task`
--

INSERT INTO `task` (`id`, `name`, `date_added`, `date_deadline`, `teacherid`, `subjectid`, `task_type_id`) VALUES
(11, 'Logarytmy', '2022-06-17', '2022-06-28', 1, 1, 4),
(12, 'policz do miliona', '2022-06-17', '2022-06-20', 1, 1, 2),
(13, 'dowiedz, że nie można dzielić przez 0', '2022-06-17', '2022-06-22', 1, 1, 5),
(14, 'sobotni sprawdzianik', '2022-06-17', '2022-06-18', 1, 1, 3),
(15, 'Zbuduj nowy most w Bydgoszczy', '2022-06-18', '2022-06-20', 1, 6, 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `task_type`
--

CREATE TABLE `task_type` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `task_type`
--

INSERT INTO `task_type` (`id`, `name`) VALUES
(1, 'Inne zadanie'),
(2, 'Praca domowa'),
(3, 'Sprawdzian'),
(4, 'Egzamin'),
(5, 'Projekt');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `teacher`
--

CREATE TABLE `teacher` (
  `id` int(11) NOT NULL,
  `name` varchar(40) NOT NULL,
  `surname` varchar(40) NOT NULL,
  `login` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `teacher`
--

INSERT INTO `teacher` (`id`, `name`, `surname`, `login`, `password`) VALUES
(1, 'Jan', 'Kowalski', 'jankowalski1', '1234'),
(3, 'Maria', 'Kowalska', 'mariakowalska1', '1234'),
(5, 'Maciej', 'Korzec', 'maciejkorzec1', 'pass'),
(6, 'Dorian', 'Krawczyk', 'doriankrawczyk1', 'pass'),
(7, 'Jacek', 'Zieliński', 'jacekzielinski1', 'pass'),
(8, 'Paweł', 'Sikora', 'pawelsikora1', 'pass'),
(9, 'Marta', 'Jankowsa', 'martajankowska1', 'pass'),
(10, 'Sylwia', 'Kaczmarek', 'sylwiakaczmarek1', 'pass'),
(11, 'admin', 'admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `teacher_subject`
--

CREATE TABLE `teacher_subject` (
  `id` int(11) NOT NULL,
  `teacherid` int(11) NOT NULL,
  `subjectid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `teacher_subject`
--

INSERT INTO `teacher_subject` (`id`, `teacherid`, `subjectid`) VALUES
(2, 1, 1),
(3, 1, 6),
(4, 3, 3),
(5, 5, 4),
(6, 6, 5),
(7, 7, 7),
(8, 8, 8),
(9, 10, 9);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `attendence`
--
ALTER TABLE `attendence`
  ADD PRIMARY KEY (`id`),
  ADD KEY `attendance_FK_studentid` (`studentid`),
  ADD KEY `attendance_FK_subjectid` (`subjectid`);

--
-- Indeksy dla tabeli `mark`
--
ALTER TABLE `mark`
  ADD PRIMARY KEY (`id`),
  ADD KEY `mark_FK_studentid` (`studentid`),
  ADD KEY `mark_FK_taksid` (`taskid`);

--
-- Indeksy dla tabeli `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `student_subject`
--
ALTER TABLE `student_subject`
  ADD PRIMARY KEY (`id`),
  ADD KEY `student-subject_FK_studentid` (`studentid`),
  ADD KEY `student-subject_FK_subjectid` (`subjectid`);

--
-- Indeksy dla tabeli `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `task`
--
ALTER TABLE `task`
  ADD PRIMARY KEY (`id`),
  ADD KEY `task_FK_subjectid` (`subjectid`),
  ADD KEY `task_FK_teacherid` (`teacherid`),
  ADD KEY `task_FK_task_type_id` (`task_type_id`);

--
-- Indeksy dla tabeli `task_type`
--
ALTER TABLE `task_type`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `teacher_subject`
--
ALTER TABLE `teacher_subject`
  ADD PRIMARY KEY (`id`),
  ADD KEY `teacher-subject_FK_subjectid` (`subjectid`),
  ADD KEY `teacher-subject_FK_teacherid` (`teacherid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `attendence`
--
ALTER TABLE `attendence`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT dla tabeli `mark`
--
ALTER TABLE `mark`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT dla tabeli `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT dla tabeli `student_subject`
--
ALTER TABLE `student_subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT dla tabeli `subject`
--
ALTER TABLE `subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT dla tabeli `task`
--
ALTER TABLE `task`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT dla tabeli `task_type`
--
ALTER TABLE `task_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT dla tabeli `teacher`
--
ALTER TABLE `teacher`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT dla tabeli `teacher_subject`
--
ALTER TABLE `teacher_subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `attendence`
--
ALTER TABLE `attendence`
  ADD CONSTRAINT `attendance_FK_studentid` FOREIGN KEY (`studentid`) REFERENCES `student` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `attendance_FK_subjectid` FOREIGN KEY (`subjectid`) REFERENCES `subject` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `mark`
--
ALTER TABLE `mark`
  ADD CONSTRAINT `mark_FK_studentid` FOREIGN KEY (`studentid`) REFERENCES `student` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `mark_FK_taksid` FOREIGN KEY (`taskid`) REFERENCES `task` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `student_subject`
--
ALTER TABLE `student_subject`
  ADD CONSTRAINT `student-subject_FK_studentid` FOREIGN KEY (`studentid`) REFERENCES `student` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `student-subject_FK_subjectid` FOREIGN KEY (`subjectid`) REFERENCES `subject` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `task`
--
ALTER TABLE `task`
  ADD CONSTRAINT `task_FK_subjectid` FOREIGN KEY (`subjectid`) REFERENCES `subject` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `task_FK_task_type_id` FOREIGN KEY (`task_type_id`) REFERENCES `task_type` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `task_FK_teacherid` FOREIGN KEY (`teacherid`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `teacher_subject`
--
ALTER TABLE `teacher_subject`
  ADD CONSTRAINT `teacher-subject_FK_subjectid` FOREIGN KEY (`subjectid`) REFERENCES `subject` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `teacher-subject_FK_teacherid` FOREIGN KEY (`teacherid`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
