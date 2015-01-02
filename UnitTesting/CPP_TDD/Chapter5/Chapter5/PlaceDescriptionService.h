#ifndef PLACE_DESCRIPTION_SERVICE_H
#define PLACE_DESCRIPTION_SERVICE_H

#include <string>
#include <memory>

class Http;

class PlaceDescriptionService
{
public:
	PlaceDescriptionService(Http *http);

	std::string summaryDescription(const std::string &latitude, const std::string &longitude) const;
	std::string summaryDescription(const std::string &response) const;

	std::string createGetRequestUrl(const std::string &latitude, const std::string &longitude) const;
	std::string get(const std::string &requestUrl) const;
	std::string keyValue(const std::string &key, const std::string &value) const;

private:
	Http *http_;
};

#endif // !PLACE_DESCRIPTION_SERVICE_H