# TaskGraphQl

INSERT INTO "Statuses" ("Id", "Title") VALUES
(1, 'New'),
(2, 'Open'),
(3, 'InProgress'),
(4, 'Done');

INSERT INTO "UserRoles" ("Id", "Title") VALUES
(1, 'User'),
(2, 'Admin');

INSERT INTO "Users" ("Id", "Username", "Email", "UserRoleId")
VALUES 
('2b828789-6001-47cc-8d10-70144b752686', 'admin1', 'admin1@example.com', 2),
('1e1d0720-290e-484a-a615-15e7245f384c', 'admin2', 'admin2@example.com',  2),
('75e3c4fb-c4e0-467b-a099-9ff0aa5d0960', 'admin3', 'admin3@example.com',  2),
('a34b0e28-ece2-4426-bdad-79946a8d036a', 'user1', 'user1@example.com',  1),
('40682aa1-8546-41d0-bfab-fa68cd79b35c', 'user2', 'user2@example.com', 1),
('b8f72136-4bb4-4cc6-98be-cc1030cfb1f4', 'user3', 'user3@example.com',  1),
('7caff5b1-a2c6-4002-a1b2-dda0f7cbf5c4', 'user4', 'user4@example.com', 1),
('8ae17b7f-ebc1-49ee-908d-59f981732d81', 'user5', 'user5@example.com', 1),
('79f526da-b8d4-43b4-9023-69504530ca66', 'user6', 'user6@example.com', 1),
('cf1504f8-bd18-4c60-9b11-909efd79555b', 'user7', 'user7@example.com', 1);

INSERT INTO "Tasks" ("Title", "Description", "CreatedAt", "StatusId", "CreatedById") VALUES
-- admin1
('Task 1', 'Description 1', CURRENT_DATE - INTERVAL '50 days', 1, '2b828789-6001-47cc-8d10-70144b752686'),
('Task 2', 'Description 2', CURRENT_DATE - INTERVAL '49 days', 2, '2b828789-6001-47cc-8d10-70144b752686'),
('Task 3', 'Description 3', CURRENT_DATE - INTERVAL '48 days', 3, '2b828789-6001-47cc-8d10-70144b752686'),
('Task 4', 'Description 4', CURRENT_DATE - INTERVAL '47 days', 4, '2b828789-6001-47cc-8d10-70144b752686'),
('Task 5', 'Description 5', CURRENT_DATE - INTERVAL '46 days', 1, '2b828789-6001-47cc-8d10-70144b752686'),

-- admin2
('Task 6', 'Description 6', CURRENT_DATE - INTERVAL '45 days', 2, '1e1d0720-290e-484a-a615-15e7245f384c'),
('Task 7', 'Description 7', CURRENT_DATE - INTERVAL '44 days', 3, '1e1d0720-290e-484a-a615-15e7245f384c'),
('Task 8', 'Description 8', CURRENT_DATE - INTERVAL '43 days', 4, '1e1d0720-290e-484a-a615-15e7245f384c'),
('Task 9', 'Description 9', CURRENT_DATE - INTERVAL '42 days', 1, '1e1d0720-290e-484a-a615-15e7245f384c'),
('Task 10', 'Description 10', CURRENT_DATE - INTERVAL '41 days', 2, '1e1d0720-290e-484a-a615-15e7245f384c'),

-- admin3
('Task 11', 'Description 11', CURRENT_DATE - INTERVAL '40 days', 3, '75e3c4fb-c4e0-467b-a099-9ff0aa5d0960'),
('Task 12', 'Description 12', CURRENT_DATE - INTERVAL '39 days', 4, '75e3c4fb-c4e0-467b-a099-9ff0aa5d0960'),
('Task 13', 'Description 13', CURRENT_DATE - INTERVAL '38 days', 1, '75e3c4fb-c4e0-467b-a099-9ff0aa5d0960'),
('Task 14', 'Description 14', CURRENT_DATE - INTERVAL '37 days', 2, '75e3c4fb-c4e0-467b-a099-9ff0aa5d0960'),
('Task 15', 'Description 15', CURRENT_DATE - INTERVAL '36 days', 3, '75e3c4fb-c4e0-467b-a099-9ff0aa5d0960'),

-- user1
('Task 16', 'Description 16', CURRENT_DATE - INTERVAL '35 days', 4, 'a34b0e28-ece2-4426-bdad-79946a8d036a'),
('Task 17', 'Description 17', CURRENT_DATE - INTERVAL '34 days', 1, 'a34b0e28-ece2-4426-bdad-79946a8d036a'),
('Task 18', 'Description 18', CURRENT_DATE - INTERVAL '33 days', 2, 'a34b0e28-ece2-4426-bdad-79946a8d036a'),
('Task 19', 'Description 19', CURRENT_DATE - INTERVAL '32 days', 3, 'a34b0e28-ece2-4426-bdad-79946a8d036a'),
('Task 20', 'Description 20', CURRENT_DATE - INTERVAL '31 days', 4, 'a34b0e28-ece2-4426-bdad-79946a8d036a'),

-- user2
('Task 21', 'Description 21', CURRENT_DATE - INTERVAL '30 days', 1, '40682aa1-8546-41d0-bfab-fa68cd79b35c'),
('Task 22', 'Description 22', CURRENT_DATE - INTERVAL '29 days', 2, '40682aa1-8546-41d0-bfab-fa68cd79b35c'),
('Task 23', 'Description 23', CURRENT_DATE - INTERVAL '28 days', 3, '40682aa1-8546-41d0-bfab-fa68cd79b35c'),
('Task 24', 'Description 24', CURRENT_DATE - INTERVAL '27 days', 4, '40682aa1-8546-41d0-bfab-fa68cd79b35c'),
('Task 25', 'Description 25', CURRENT_DATE - INTERVAL '26 days', 1, '40682aa1-8546-41d0-bfab-fa68cd79b35c'),

-- user3
('Task 26', 'Description 26', CURRENT_DATE - INTERVAL '25 days', 2, 'b8f72136-4bb4-4cc6-98be-cc1030cfb1f4'),
('Task 27', 'Description 27', CURRENT_DATE - INTERVAL '24 days', 3, 'b8f72136-4bb4-4cc6-98be-cc1030cfb1f4'),
('Task 28', 'Description 28', CURRENT_DATE - INTERVAL '23 days', 4, 'b8f72136-4bb4-4cc6-98be-cc1030cfb1f4'),
('Task 29', 'Description 29', CURRENT_DATE - INTERVAL '22 days', 1, 'b8f72136-4bb4-4cc6-98be-cc1030cfb1f4'),
('Task 30', 'Description 30', CURRENT_DATE - INTERVAL '21 days', 2, 'b8f72136-4bb4-4cc6-98be-cc1030cfb1f4'),

-- user4
('Task 31', 'Description 31', CURRENT_DATE - INTERVAL '20 days', 3, '7caff5b1-a2c6-4002-a1b2-dda0f7cbf5c4'),
('Task 32', 'Description 32', CURRENT_DATE - INTERVAL '19 days', 4, '7caff5b1-a2c6-4002-a1b2-dda0f7cbf5c4'),
('Task 33', 'Description 33', CURRENT_DATE - INTERVAL '18 days', 1, '7caff5b1-a2c6-4002-a1b2-dda0f7cbf5c4'),
('Task 34', 'Description 34', CURRENT_DATE - INTERVAL '17 days', 2, '7caff5b1-a2c6-4002-a1b2-dda0f7cbf5c4'),
('Task 35', 'Description 35', CURRENT_DATE - INTERVAL '16 days', 3, '7caff5b1-a2c6-4002-a1b2-dda0f7cbf5c4'),

-- user5
('Task 36', 'Description 36', CURRENT_DATE - INTERVAL '15 days', 4, '8ae17b7f-ebc1-49ee-908d-59f981732d81'),
('Task 37', 'Description 37', CURRENT_DATE - INTERVAL '14 days', 1, '8ae17b7f-ebc1-49ee-908d-59f981732d81'),
('Task 38', 'Description 38', CURRENT_DATE - INTERVAL '13 days', 2, '8ae17b7f-ebc1-49ee-908d-59f981732d81'),
('Task 39', 'Description 39', CURRENT_DATE - INTERVAL '12 days', 3, '8ae17b7f-ebc1-49ee-908d-59f981732d81'),
('Task 40', 'Description 40', CURRENT_DATE - INTERVAL '11 days', 4, '8ae17b7f-ebc1-49ee-908d-59f981732d81'),

-- user6
('Task 41', 'Description 41', CURRENT_DATE - INTERVAL '10 days', 1, '79f526da-b8d4-43b4-9023-69504530ca66'),
('Task 42', 'Description 42', CURRENT_DATE - INTERVAL '9 days', 2, '79f526da-b8d4-43b4-9023-69504530ca66'),
('Task 43', 'Description 43', CURRENT_DATE - INTERVAL '8 days', 3, '79f526da-b8d4-43b4-9023-69504530ca66'),
('Task 44', 'Description 44', CURRENT_DATE - INTERVAL '7 days', 4, '79f526da-b8d4-43b4-9023-69504530ca66'),
('Task 45', 'Description 45', CURRENT_DATE - INTERVAL '6 days', 1, '79f526da-b8d4-43b4-9023-69504530ca66'),

-- user7
('Task 46', 'Description 46', CURRENT_DATE - INTERVAL '5 days', 2, 'cf1504f8-bd18-4c60-9b11-909efd79555b'),
('Task 47', 'Description 47', CURRENT_DATE - INTERVAL '4 days', 3, 'cf1504f8-bd18-4c60-9b11-909efd79555b'),
('Task 48', 'Description 48', CURRENT_DATE - INTERVAL '3 days', 4, 'cf1504f8-bd18-4c60-9b11-909efd79555b'),
('Task 49', 'Description 49', CURRENT_DATE - INTERVAL '2 days', 1, 'cf1504f8-bd18-4c60-9b11-909efd79555b'),
('Task 50', 'Description 50', CURRENT_DATE - INTERVAL '1 day', 2, 'cf1504f8-bd18-4c60-9b11-909efd79555b');
